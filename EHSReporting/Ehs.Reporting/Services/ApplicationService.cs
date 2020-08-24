using Ehs.Reporting.MR.Services.Contracts;
using Ehs.Reporting.MR.Services.Interface;
using Ehs.Reporting.MR.Settings;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Ehs.Reporting.MR.Services
{
    public class ApplicationService : IApplicationService
    {

        private readonly IMRContentService _contentService;
        private readonly IEmailService _emailService;
        private readonly IActiveClientsService _clientService;
        private readonly ILogger _logger;
        private readonly EmailSettings _emailSettings;

        public ApplicationService(ILogger logger,
            IActiveClientsService clientService,
            IEmailService emailService,
            EmailSettings config,
            IMRContentService contentService)
        {
            _logger = logger;
            _emailService = emailService;
            _contentService = contentService;
            _clientService = clientService;
            _emailSettings = config;
        }

        static string GetActualAsyncMethodName([CallerMemberName]string name = null) => name;

        public async Task<int> HandleAllClients(bool ShouldSendEmail)
        {
            _logger.ForContext("Source", typeof(ApplicationService).FullName)
              .ForContext("MethodName", GetActualAsyncMethodName())
              .Information("Handling all clients process with sendEmailOption: {ShouldSendEmail}", ShouldSendEmail);

            List<ResponseModel> engClientsWithContent = null;
            List<ResponseModel> transClientsWithContent = null;
            int totalResultSaved = 0;
            try
            {
                _logger.Debug("Fetching english & translated clients from database.");
                var engClients = await _clientService.GetActiveMRClientsForEnglishLang();
                var transClients = await _clientService.GetActiveMRClientsForTranslatedLang();

                _logger.Debug("English clients count: {ClientsCount}, Translated clients count: {TransClientsCount}", engClients.Count, transClients.Count);
                _logger.Debug("English Only clients: {Clients}", engClients?.Select(x => new { x.Idclient, x.ClientName }));
                _logger.Debug("Translated Only clients: {Clients}", transClients?.Select(x => new { x.Idclient, x.ClientName }));

                if (engClients != null && engClients.Any())
                {
                    _logger.Debug("Fetching content for english clients from legacy.");
                    engClientsWithContent = await _contentService.GetMRContentForClients(engClients.ToList());
                    _logger.Debug("English clint user returned from legacy- {englishUserListWithContent}", engClientsWithContent.Select(s=> new { ClientId = s.IDClient, UserCount = s.MailingList?.Count}));
                }

                if (transClients != null && transClients.Any())
                {
                    _logger.Debug("Fetching content for translated clients from legacy.");
                    transClientsWithContent = await _contentService.GetMRContentForClients(transClients.ToList());
                    _logger.Debug("Translated user returned from legacy- {translatedUserListWithContent}", transClientsWithContent.Select(s => new { ClientId = s.IDClient, UserCount = s.MailingList?.Count }));
                }
                var totalClientsWithContent = new List<ResponseModel>();
                totalClientsWithContent.AddRange(engClientsWithContent);
                totalClientsWithContent.AddRange(transClientsWithContent);

                _logger.Information("Total clients with content: {TotalClients}, {ClientUserListWithContent}", totalClientsWithContent.Count, totalClientsWithContent.Select(s => new { id = s.IDClient, name = s.ClientName,UserCount = s.MailingList.Count , EmailUsers = String.Join(",",s.MailingList.Select(m => m.Email)) }).ToList());

                if (ShouldSendEmail)
                {
                    _logger.Information("Sending email to client users in bulk.");
                    var emailsSent = await _emailService.SendBulkAsync(totalClientsWithContent.ToList(),
                        _emailSettings.BulkSize.HasValue ? _emailSettings.BulkSize.Value : 100);

                    _logger.Information("Total emails sent: {EmailSent}", emailsSent);
                }

                if (engClientsWithContent != null && engClientsWithContent.Any())
                {
                    var clientsToUpdate = engClients.Where(x => engClientsWithContent.Select(s => Convert.ToInt64(s.IDClient)).Contains(x.Idclient)).ToList();
                    if (clientsToUpdate.Any())
                    {
                        _logger.Information("updating latest MR report date for english clients {ClientIds}", clientsToUpdate.Select(c => c.Idclient));
                        var result = await _clientService.UpdateLatestMRReportDateForClients(clientsToUpdate);
                        totalResultSaved = result.Any() ? result.Count : 0;
                    }
                }

                if (transClientsWithContent != null && transClientsWithContent.Any())
                {
                    var clientsToUpdate = transClients.Where(x => transClientsWithContent.Select(s => Convert.ToInt64(s.IDClient)).Contains(x.Idclient)).ToList();
                    if (clientsToUpdate.Any())
                    {
                        _logger.Information("updating latest MR report date for translated clients {ClientIds}", clientsToUpdate.Select(c => c.Idclient));
                        var result = await _clientService.UpdateLatestMRReportDateForClients(clientsToUpdate);
                        totalResultSaved += result.Any() ? result.Count : 0;
                    }
                }

                return await Task.FromResult(totalResultSaved);
            }
            catch (Exception ex)
            {
                _logger.ForContext("Source", typeof(ApplicationService).FullName)
                .ForContext("MethodName", GetActualAsyncMethodName())
                .Error(ex, "Am exception occured on application service level.");

                throw;
            }
        }

        public async Task<int> HandleEnglishOnlyClients(bool shouldSendEmail)
        {
            _logger.ForContext("Source", typeof(ApplicationService).FullName)
              .ForContext("MethodName", GetActualAsyncMethodName())
              .Information("Handling english only clients process with sendEmailOption: {ShouldSendEmail}", shouldSendEmail);

            List<ResponseModel> engClientsWithContent = null;
            int totalResultSaved = 0;
            try
            {
                _logger.Debug("Fetching english only clients from database.");
                var engClients = await _clientService.GetActiveMRClientsForEnglishLang();

                _logger.Debug("English clients count: {ClientsCount}", engClients.Count);
                _logger.Debug("English Only clients: {Clients}", engClients?.Select(x => new { x.Idclient, x.ClientName }));

                if (engClients != null && engClients.Any())
                {
                    _logger.Debug("Fetching content for english clients from legacy.");
                    engClientsWithContent = await _contentService.GetMRContentForClients(engClients.ToList());
                }

                if (shouldSendEmail)
                {
                    _logger.Information("Sending email to client users in bulk.");
                    var emailsSent = await _emailService.SendBulkAsync(engClientsWithContent.ToList(),
                        _emailSettings.BulkSize.HasValue ? _emailSettings.BulkSize.Value : 100);

                    _logger.Information("Total email sent: {EmailSent}", emailsSent);
                }

                if (engClientsWithContent != null && engClientsWithContent.Any())
                {
                    var clientsToUpdate = engClients.Where(x => engClientsWithContent.Select(s => Convert.ToInt64(s.IDClient)).Contains(x.Idclient)).ToList();
                    if (clientsToUpdate.Any())
                    {
                        _logger.Information("updating latest MR report date for english clients {ClientIds}", clientsToUpdate.Select(c => c.Idclient));
                        var result = await _clientService.UpdateLatestMRReportDateForClients(clientsToUpdate);
                        totalResultSaved = result.Any() ? result.Count : 0;
                    }
                }

                return await Task.FromResult(totalResultSaved);
            }
            catch (Exception ex)
            {
                _logger.ForContext("Source", typeof(ApplicationService).FullName)
                                .ForContext("MethodName", GetActualAsyncMethodName())
                                .Error(ex, "Am exception occured on application service level.");

                throw;
            }

        }

        public async Task<int> HandleTranslatedClients(bool shouldSendEmail)
        {
            _logger.ForContext("Source", typeof(ApplicationService).FullName)
             .ForContext("MethodName", GetActualAsyncMethodName())
             .Information("Handling translated only clients process with sendEmailOption: {ShouldSendEmail}", shouldSendEmail);

            List<ResponseModel> transClientsWithContent = null;
            int totalResultSaved = 0;
            try
            {
                _logger.Debug("Fetching translated only clients from database.");
                var transClients = await _clientService.GetActiveMRClientsForTranslatedLang();

                _logger.Debug("Translated clients count: {clientsCount }", transClients.Count);
                _logger.Debug("Translated Only clients: {Clients}", transClients?.Select(x => new { x.Idclient, x.ClientName }));

                if (transClients != null && transClients.Any())
                {
                    _logger.Debug("Fetching content for translated clients from legacy.");
                    transClientsWithContent = await _contentService.GetMRContentForClients(transClients.ToList());
                }

                if (shouldSendEmail)
                {
                    _logger.Information("Sending email to client users in bulk.");
                    var emailsSent = await _emailService.SendBulkAsync(transClientsWithContent.ToList(),
                        _emailSettings.BulkSize.HasValue ? _emailSettings.BulkSize.Value : 100);

                    _logger.Information("Total email sent: {EmailSent}", emailsSent);
                }

                if (transClientsWithContent != null && transClientsWithContent.Any())
                {
                    var clientsToUpdate = transClients.Where(x => transClientsWithContent.Select(s => Convert.ToInt64(s.IDClient)).Contains(x.Idclient)).ToList();
                    if (clientsToUpdate.Any())
                    {
                        _logger.Information("updating latest MR report date for translated clients {ClientIds}", clientsToUpdate.Select(c => c.Idclient));
                        var result = await _clientService.UpdateLatestMRReportDateForClients(clientsToUpdate);
                        totalResultSaved = result.Any() ? result.Count : 0;
                    }
                }

                return await Task.FromResult(totalResultSaved);
            }
            catch (Exception ex)
            {
                _logger.ForContext("Source", typeof(ApplicationService).FullName)
                                .ForContext("MethodName", GetActualAsyncMethodName())
                                .Error(ex, "Am exception occured on application service level.");

                throw;
            }
        }

        public async Task<int> HandleForClientIds(List<int> clientIds, bool shouldSendEmail)
        {
            _logger.ForContext("Source", typeof(ApplicationService).FullName)
                  .ForContext("MethodName", GetActualAsyncMethodName())
                  .Information("Handling  process for client ids {ClientIds} sendEmailOption: {ShouldSendEmail}", clientIds, shouldSendEmail);
            int totalRecordsProcessed = 0;
            List<ResponseModel> engClientsWithContent = new List<ResponseModel>();
            List<ResponseModel> transClientsWithContent = new List<ResponseModel>();
            try
            {
                _logger.Debug("Fetching english & translated clients from database.");
                var engClients = await _clientService.GetActiveMRClientsForEnglishLang();
                var transClients = await _clientService.GetActiveMRClientsForTranslatedLang();

                var eng = engClients.Where(c => clientIds.Contains(c.Idclient));
                var trans = transClients.Where(c => clientIds.Contains(c.Idclient));
                var exceptions = clientIds.Except(eng.Concat(trans).Select(s => s.Idclient));

                if (exceptions.Any())
                    _logger.Warning("The {ClientIds} are not found in any of english or translated clients. they will not process.", string.Join(',', exceptions));

                if (eng != null && eng.Any())
                {
                    _logger.Debug("Fetching content for english clients from legacy.");
                    engClientsWithContent = await _contentService.GetMRContentForClients(eng.ToList());
                }
                if (trans != null && trans.Any())
                {
                    _logger.Debug("Fetching content for translated clients from legacy.");
                    transClientsWithContent = await _contentService.GetMRContentForClients(trans.ToList());
                }
                var totalClientsWithContent = engClientsWithContent.Concat(transClientsWithContent);

                _logger.Information("Total clients with content: {totalClients} {ClientIds}", totalClientsWithContent.Count(), totalClientsWithContent.Select(s => s.IDClient));

                if (shouldSendEmail)
                {
                    _logger.Information("Sending email to client users in bulk.");
                    var emailsSent = await _emailService.SendBulkAsync(totalClientsWithContent.ToList(),
                        _emailSettings.BulkSize.HasValue ? _emailSettings.BulkSize.Value : 100);

                    _logger.Information("Total email sent: {EmailSent}", emailsSent);
                }

                if (engClientsWithContent != null && engClientsWithContent.Any())
                {
                    var clientsToUpdate = eng.Where(x => engClientsWithContent.Select(s => Convert.ToInt64(s.IDClient)).Contains(x.Idclient)).ToList();
                    if (clientsToUpdate.Any())
                    {
                        _logger.Information("updating latest MR report date for english clients {ClientIds}", clientsToUpdate.Select(c => c.Idclient));
                        var result = await _clientService.UpdateLatestMRReportDateForClients(clientsToUpdate).ConfigureAwait(false);
                        totalRecordsProcessed = result != null && result.Any() ? result.Count : 0;
                    }
                }

                if (transClientsWithContent != null && transClientsWithContent.Any())
                {
                    var clientsToUpdate = trans.Where(x => transClientsWithContent.Select(s => Convert.ToInt64(s.IDClient)).Contains(x.Idclient)).ToList();
                    if (clientsToUpdate.Any())
                    {
                        _logger.Information("updating latest MR report date for translated clients {ClientIds}", clientsToUpdate.Select(c => c.Idclient));
                        var result = await _clientService.UpdateLatestMRReportDateForClients(clientsToUpdate).ConfigureAwait(false);
                        totalRecordsProcessed += result != null && result.Any() ? result.Count : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.ForContext("Source", typeof(ApplicationService).FullName)
                       .ForContext("MethodName", GetActualAsyncMethodName())
                       .Error(ex, "Am exception occured on application service level.");
            }

            return await Task.FromResult(totalRecordsProcessed);
        }

        public async Task<int> HandleForClientUserIds(int clientId, List<string> userIds, bool shouldSendEmail)
        {
            _logger.ForContext("Source", typeof(ApplicationService).FullName)
                  .ForContext("MethodName", GetActualAsyncMethodName())
                  .Information("Handling  process for {ClientId} {userIds} sendEmailOption: {ShouldSendEmail}", clientId, userIds, shouldSendEmail);
            int totalRecordsProcessed = 0;
            ResponseModel engClientUsers = null;
            ResponseModel transClientUsers = null;
            try
            {
                _logger.Debug("Fetching english & translated clients from database.");
                var engClients = await _clientService.GetActiveMRClientsForEnglishLang().ConfigureAwait(false);
                var transClients = await _clientService.GetActiveMRClientsForTranslatedLang().ConfigureAwait(false);

                var eng = engClients.FirstOrDefault(_ => _.Idclient == clientId);
                if (eng != null)
                {
                    engClientUsers = await _contentService.GetMRUsersForClient(eng).ConfigureAwait(false);
                }
                else
                {
                    var trans = transClients.FirstOrDefault(_ => _.Idclient == clientId);

                    if (trans != null)
                        transClientUsers = await _contentService.GetMRUsersForClient(trans).ConfigureAwait(false);
                    else
                        _logger.Information("The provided {ClientId} does not match either from english or translated clients.", clientId);
                }

                if (engClientUsers == null && !engClientUsers.MailingList.Any()
                    && transClientUsers == null && !transClientUsers.MailingList.Any())
                {
                    _logger.Information("There are no active users for the give {ClientId}", clientId);

                    return await Task.FromResult(totalRecordsProcessed);
                }

                if (engClientUsers != null && engClientUsers.MailingList.Any())
                {
                    var invalidUsers = userIds.Except(engClientUsers.MailingList.Select(_ => _.Email), StringComparer.InvariantCultureIgnoreCase);
                    if (invalidUsers.Any())
                    {
                        _logger.Information("The {UserEmailIds} are not valid active users for english client. They will not be processed.", string.Join(',', invalidUsers));
                        userIds = userIds.Except(invalidUsers).ToList();
                        userIds
                            .ToList()
                            .ForEach(f => engClientUsers.MailingList
                                .Remove(engClientUsers.MailingList
                                .FirstOrDefault(s =>
                                    s.Email.Equals(f, StringComparison.CurrentCultureIgnoreCase))));
                    }

                    engClientUsers.MailingList = engClientUsers.MailingList.FindAll (s => userIds.Contains(s.Email,StringComparer.InvariantCultureIgnoreCase));
                    //Get content for users
                    var usersWithContent = await _contentService.GetEmailContentForUsers(engClientUsers).ConfigureAwait(false);

                    if (shouldSendEmail)
                    {
                        // send email to users
                        _logger.Information("Sending email to client users in bulk.");
                        var emailsSent = await _emailService.SendBulkAsync(usersWithContent,
                            _emailSettings.BulkSize.HasValue ? _emailSettings.BulkSize.Value : 100).ConfigureAwait(false);

                        totalRecordsProcessed = emailsSent;
                        _logger.Information("Total email sent: {EmailSent}", emailsSent);
                    }
                    // Update MR report date for english users

                    _logger.Information("updating latest MR report date for english clients {ClientIds}", clientId);

                    await _clientService.UpdateLatestMRReportDateForClients(engClients.Where(_ => _.Idclient == clientId).ToList()).ConfigureAwait(false);

                }
                else if (transClientUsers != null && transClientUsers.MailingList.Any())
                {
                    var invalidUsers = userIds.Except(transClientUsers.MailingList.Select(_ => _.Email), StringComparer.InvariantCultureIgnoreCase);
                    if (invalidUsers.Any())
                    {
                        _logger.Information("The {UserEmailIds} are not valid active users for translated client. They will not be processed.", string.Join(',', invalidUsers));
                        userIds = userIds.Except(invalidUsers).ToList();

                        userIds
                            .ToList()
                            .ForEach(f => transClientUsers.MailingList
                                .Remove(transClientUsers.MailingList
                                .FirstOrDefault(s =>
                                    s.Email.Equals(f, StringComparison.CurrentCultureIgnoreCase))));
                    }

                    transClientUsers.MailingList = transClientUsers.MailingList.FindAll(s => userIds.Contains(s.Email, StringComparer.InvariantCultureIgnoreCase));
                    //Get content for users
                    var usersWithContent = await _contentService.GetEmailContentForUsers(transClientUsers).ConfigureAwait(false);

                    if (shouldSendEmail)
                    {
                        // send email to users
                        _logger.Information("Sending email to client users in bulk.");
                        var emailsSent = await _emailService.SendBulkAsync(usersWithContent,
                            _emailSettings.BulkSize.HasValue ? _emailSettings.BulkSize.Value : 100).ConfigureAwait(false);

                        totalRecordsProcessed = emailsSent;
                        _logger.Information("Total email sent: {EmailSent}", emailsSent);
                    }
                    // Update MR report date for english users

                    _logger.Information("updating latest MR report date for translated clients {ClientIds}", clientId);

                    await _clientService.UpdateLatestMRReportDateForClients(transClients.Where(_ => _.Idclient == clientId).ToList()).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                _logger.ForContext("Source", typeof(ApplicationService).FullName)
                       .ForContext("MethodName", GetActualAsyncMethodName())
                       .Error(ex, "Am exception occured on application service level.");
                throw;
            }

            return await Task.FromResult(totalRecordsProcessed);

        }


    }
}
