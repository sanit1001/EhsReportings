using Ehs.Reporting.MR.Helpers;
using Ehs.Reporting.MR.Services.Contracts;
using Ehs.Reporting.MR.Settings;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Ehs.Reporting.MR.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _configuration;

        private readonly ILogger _logger;
        public EmailService(EmailSettings configuration, ILogger logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        static string GetActualAsyncMethodName([CallerMemberName]string name = null) => name;

        public async Task<int> SendBulkAsync(IList<ResponseModel> recipients, int batchSize)
        {
            _logger.ForContext("Source", typeof(EmailService).FullName)
                   .ForContext("MethodName", GetActualAsyncMethodName())
                   .Information("Starting process to send Emails in batches. BatchSize {BatchSize} {RecipientSize}", batchSize, recipients.Count);
            int emailSent = 0;
            if (recipients != null && recipients.Count > 0)
            {
                // var emails = recipients.Where(e => e.MailingList != null).SelectMany(x => x.MailingList);
                var emails = new List<MailingListModel>();
                recipients.Where(e => e.MailingList != null).ToList().ForEach(f => emails.AddRange(f.MailingList));

                if (emails == null || emails.Count == 0)
                {
                    _logger.Information("There is no user to send an email. User list is null.");
                    return emailSent;
                }

                _logger.Information("Total {EmailObjCount} from all recipients.", emails.Count);

                emailSent = await SendEmailToUsersAsync(batchSize, emails);

                _logger.Information("Total email sent {EmailCount}/{TotalUserWithContentCount}", emailSent, emails.Count);
            }
            else
            {
                _logger.Information("Email not sent because recipient list is null.");
            }

            return emailSent;
        }

        public async Task<int> SendBulkAsync(ResponseModel recipient, int batchSize)
        {
            _logger.ForContext("Source", typeof(EmailService).FullName)
                   .ForContext("MethodName", GetActualAsyncMethodName())
                   .Information("Starting process to send Emails in batches. BatchSize {BatchSize}", batchSize);

            int emailSent = 0;
            if (recipient != null && recipient.MailingList.Any())
            {
                emailSent = await SendEmailToUsersAsync(batchSize, recipient.MailingList);

                _logger.Information("Total email sent {EmailCount}/{TotalUserCount}", emailSent, recipient.MailingList.Count());
            }
            else
            {
                _logger.Information("Email not sent because recipient list is null.");
            }

            return emailSent;
        }

        private async Task<int> SendEmailToUsersAsync(int batchSize, IEnumerable<MailingListModel> emails)
        {
            int emailSent = 0;
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.UseDefaultCredentials = true;

                var credential = new NetworkCredential
                {
                    UserName = _configuration.UserName,
                    Password = _configuration.Password
                };

                smtpClient.Credentials = credential;
                smtpClient.Host = _configuration.Host;
                smtpClient.Port = int.Parse(_configuration.Port);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                CounterHelper.CounterStruct.Counter = 0;

                foreach (var batch in emails.Batch(batchSize))
                {
                    _logger.Information("Sending email for batch: {Batch}/ {TotalBatches} with {BatchSize} ", CounterHelper.CounterStruct.Counter + 1, emails.Count() / batchSize + emails.Count() % batchSize, batchSize);

                    foreach (var item in batch)
                    {
                        try
                        {
                            _logger.Debug("Sending Email to user {EmailAddress}", item.Email);

                            using (var emailMessage = new MailMessage())
                            {
                                string sendToEmail = _configuration.ShouldSendEmailToTestUser ? _configuration.TestUserEmail : item.Email;
                                emailMessage.To.Add(new MailAddress(sendToEmail));
                                emailMessage.From = new MailAddress(_configuration.SenderEmail, _configuration.SenderName);

                                emailMessage.Subject = item.EmailSubject;
                                emailMessage.IsBodyHtml = true;
                                emailMessage.Body = item.EmailBody;
                                smtpClient.Send(emailMessage);
                                emailSent++;

                                _logger.Information("Email sent successfully to user {EmailAddress}", item.Email);
                            }
                        }
                        catch (Exception ex)
                        {
                            _logger.ForContext("Source", typeof(EmailService).FullName)
                                .ForContext("MethodName", GetActualAsyncMethodName())
                                .ForContext("EmailAddress", item.Email)
                                .Error(ex, "An error occured while sending email to user {UserId}. Process will continue to next user.", item.Email);
                            continue;
                        }

                    }
                    CounterHelper.CounterStruct.Counter++;
                    await Task.Delay(_configuration.DelayPerBatchMiliSeconds ?? 5000);

                    _logger.Debug("Sending email for {Batch} completed.", CounterHelper.CounterStruct.Counter);
                }

            }

            return emailSent;
        }
    }
}
