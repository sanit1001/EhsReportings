using Ehs.Reporting.MR.Helpers;
using Ehs.Reporting.MR.Models;
using Ehs.Reporting.MR.Services.Contracts;
using Ehs.Reporting.MR.Settings;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Ehs.Reporting.MR.Services
{
    public class MRContentService : IMRContentService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly MRContentSettings _config;
        private readonly ILogger _logger;

        public MRContentService(ILogger logger,
            MRContentSettings config,
            IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _config = config;
            _clientFactory = clientFactory;
        }

        static string GetActualAsyncMethodName([CallerMemberName]string name = null) => name;

        public async Task<List<ResponseModel>> GetMRContentForClients(List<Client> clientIds)
        {

            if (clientIds == null || !clientIds.Any())
            {
                _logger.ForContext("Source", typeof(MRContentService).FullName)
               .ForContext("MethodName", GetActualAsyncMethodName())
               .Information("No client ids are provided. Retuning null.");

                return null;
            }

            var totalRecordCount = clientIds.Count;

            _logger.ForContext("Source", typeof(MRContentService).FullName)
               .ForContext("MethodName", GetActualAsyncMethodName())
               .Information("Get MR content for clients:{ClientIdCount} Clients: {ClientIds}", totalRecordCount, string.Join(',', clientIds.Select(x => x.Idclient).ToList()));

            List<ResponseModel> mailingLists = new List<ResponseModel>();
            var result = new List<ResponseModel>();


            int batchSize = _config.ProcessInBatchSize ?? 1;
            CounterHelper.CounterStruct.Counter = 0;
            _logger.Debug("Starting process: Get all Users for each client in batches batchSize: {BatchSize}.", batchSize);

            foreach (var batch in clientIds.Batch(batchSize))
            {
                try
                {
                    _logger.Information("Processing batch: {BatchCount} / {Batches} with batchSize: {BatchSize}", CounterHelper.CounterStruct.Counter + 1, totalRecordCount / batchSize + totalRecordCount % batchSize, batchSize);

                    var tasks = batch.Select(async cl => { await GetUsersForClientAsync(cl, mailingLists, CounterHelper.CounterStruct.Counter).ConfigureAwait(false); });
                    await Task.WhenAll(tasks);

                    _logger.Information("Batch processing completed batchCount: {BatchCount}.", CounterHelper.CounterStruct.Counter + 1);
                }
                catch (Exception ex)
                {
                    _logger.ForContext("Batch", batch)
                        .ForContext("Source", typeof(MRContentService).FullName)
                        .ForContext("MethodName", GetActualAsyncMethodName())
                        .Error(ex, "Error occured while getting users from client list. Error is suppressed to continue.");

                    continue;
                }
            }
            _logger.Debug("Completed process: Get all Users for each client in batches.");
            _logger.Debug("Starting process: Get Email Content for all Users per client.");
            _logger.Debug("Getting Email content for returned users.{ClientUserList}", mailingLists.Select(s => new { Id = s.IDClient, Name = s.ClientName, UserCount = s.MailingList?.Count, Users = string.Join(",", s.MailingList?.Select(m => m.Email)) }));

            foreach (var item in mailingLists)
            {
                try
                {
                    _logger.Debug("Get Email content for users: {UserCount} for client {ClientId}", item.MailingList?.Count, item.IDClient);

                    var userContent = await GetEmailContentFromResult(item).ConfigureAwait(false);
                    item.MailingList = userContent.ToList();
                    result.Add(item);
                }
                catch (Exception ex)
                {
                    _logger
                        .ForContext("Source", typeof(MRContentService).FullName)
                        .ForContext("MethodName", GetActualAsyncMethodName())
                        .ForContext("ClientId", item.IDClient)
                        .ForContext("ClientName", item.ClientName)
                        .Error(ex, "Error occured while getting email content for each user of a client {ClientId}. Exception is supressed to continue process. Exception Message {Message}", item.IDClient, ex.Message);

                    continue;
                }
            }
            _logger.Debug("Result with {ClientCount} and {UserContent}.", result.Count, result.Select(s=> new {Id = s.IDClient, Name = s.ClientName, UserCount = s.MailingList?.Count, Users = string.Join(",", s.MailingList?.Select(m=>m.Email)) }));

            return result;
        }

        public async Task<ResponseModel> GetMRUsersForClient(Client client)
        {
            if (client == null)
            {
                _logger.ForContext("Source", typeof(MRContentService).FullName)
               .ForContext("MethodName", GetActualAsyncMethodName())
               .Information("No client id is provided. Retuning null.");

                return null;
            }

            _logger.ForContext("Source", typeof(MRContentService).FullName)
               .ForContext("MethodName", GetActualAsyncMethodName())
               .Information("Get MR content for client: {ClientId}.", client.Idclient);

            CounterHelper.CounterStruct.Counter = 0;
            List<ResponseModel> mailingLists = new List<ResponseModel>();

            try
            {
                var result = await GetUsersForClientAsync(client, mailingLists, CounterHelper.CounterStruct.Counter);
                if (result == 1)
                {
                    return mailingLists.First();
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.ForContext("Source", typeof(MRContentService).FullName)
                       .ForContext("MethodName", GetActualAsyncMethodName())
                       .Error(ex, "GetMRUsersForClient - An exception has occured while getting users for {ClientId}", client.Idclient);

                throw;
            }

        }

        public async Task<ResponseModel> GetEmailContentForUsers(ResponseModel model)
        {
            _logger.ForContext("Source", typeof(MRContentService).FullName)
                       .ForContext("MethodName", GetActualAsyncMethodName())
                       .ForContext("ClinetId", model.IDClient)
                       .ForContext("ClientName", model.ClientName)
                       .Information("GetEmailContentForUsers {UserEmailIds}", model.MailingList.Select(s => s.Email));

            var userConetnt = await GetEmailContentFromResult(model).ConfigureAwait(false);

            model.MailingList = userConetnt.ToList();

            return model;
        }

        private async Task<int> GetUsersForClientAsync(Client c, List<ResponseModel> mailingLists, int counter)
        {
            var client = _clientFactory.CreateClient();
            client.Timeout = TimeSpan.FromMinutes(_config.RequestTimeoutInMinutes ?? 10);
            CounterHelper.CounterStruct.Counter = counter + 1;

            _logger.ForContext("Source", typeof(MRContentService).FullName)
                   .ForContext("MethodName", GetActualAsyncMethodName())
                   .ForContext("ClinetId", c.Idclient)
                   .ForContext("ClientName", c.ClientName)
                   .Information("GetUsersForClientAsync Count: {Count} ClinetId:{ClientId} ClientName:{ClientName} ", CounterHelper.CounterStruct.Counter, c.Idclient, c.ClientName);

            try
            {
                var requestUrl = string.Format(_config.ProviderURL, c.Idclient, c.ClientName);

                _logger.Debug($"{CounterHelper.CounterStruct.Counter} : Requesting content from URL: {requestUrl}");

                if (!string.IsNullOrEmpty(requestUrl))
                {
                    var response = await client.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();

                        if (!string.IsNullOrEmpty(content))
                        {
                            _logger.Debug("{Counter} : Request succeeded with content: {Content}", CounterHelper.CounterStruct.Counter, content);

                            var resultSet = JsonConvert.DeserializeObject<ResponseModel>(content);

                            mailingLists.Add(resultSet);

                            _logger.Debug("ClientUserCount: Total {UserCount} for {ClientId}.", resultSet.MailingList?.Count, resultSet.IDClient);
                        }
                        else
                        {
                            _logger.Information("Request to get users for {RequestUrl} returns NULL content", requestUrl);
                        }

                    }
                    else
                    {
                        _logger.Warning($" Request to get users for clients failed with status: {response.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                _logger.ForContext("Source", typeof(MRContentService).FullName)
                   .ForContext("MethodName", GetActualAsyncMethodName())
                   .ForContext("ClinetId", c.Idclient)
                   .ForContext("ClientName", c.ClientName)
                    .Error(ex, "An exception has occured for {ClientId} when getting user list for client.", c.Idclient);
                throw;
            }

            return CounterHelper.CounterStruct.Counter;

        }

        private async Task<ICollection<MailingListModel>> GetEmailContentFromResult(ResponseModel resultSet)
        {
            _logger.ForContext("Source", typeof(MRContentService).FullName)
                  .ForContext("MethodName", GetActualAsyncMethodName())
                  .ForContext("ClinetId", resultSet.IDClient)
                  .ForContext("ClientName", resultSet.ClientName)
                  .Information("Getting email content for client {ClientId} users:{Users}.", resultSet.IDClient, resultSet.MailingList.Select(s => s.Email));

            if (resultSet != null && resultSet.MailingList.Count > 0)
            {
                var httpClient = _clientFactory.CreateClient();
                httpClient.Timeout = TimeSpan.FromMinutes(_config.RequestTimeoutInMinutes ?? 10);

                var tasks = resultSet.MailingList.Select(async i => await GetEmailContentFromEmailURLAsync(i, httpClient, resultSet.IDClient).ConfigureAwait(false));

                return await Task.WhenAll(tasks).ConfigureAwait(false);

            }

            return null;
        }


        private async Task<MailingListModel> GetEmailContentFromEmailURLAsync(MailingListModel model, HttpClient client, string clientId)
        {
            _logger.ForContext("Source", typeof(MRContentService).FullName)
                  .ForContext("MethodName", GetActualAsyncMethodName())
                  .ForContext("UserEmail", model.Email)
                  .ForContext("ClientId", clientId)
                  .Debug("Getting email content for {User}", model.Email);

            try
            {
                var response = await client.GetStringAsync(model.EmailURL).ConfigureAwait(false);
                model.EmailBody = response;

                _logger.Information("Request completed for {Url}. {ContentLength}", model.EmailURL, response?.Length);
                _logger.Verbose("Request completed for {Url} {Content}.", model.EmailURL, response);
            }
            catch (Exception ex)
            {
                _logger.ForContext("Source", typeof(MRContentService).FullName)
                                  .ForContext("MethodName", GetActualAsyncMethodName())
                                  .ForContext("UserEmail", model.Email)
                                  .ForContext("ClientId", clientId)
                                  .Error(ex, "An exception occured when getting email content for user.");
                throw;
            }

            return model;
        }
    }
}
