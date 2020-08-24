using Ehs.Reporting.MR.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Ehs.Reporting.MR.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly EhsSqlContext _dbContext;
        private List<MrDataContext> DataContextSet { get; set; }
        private readonly ILogger _logger;
       
        public ClientRepository(EhsSqlContext context, ILogger logger)
        {
            _dbContext = context;
            _dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _logger = logger;
        }
        static string GetActualAsyncMethodName([CallerMemberName]string name = null) => name;

        public async Task<IList<Client>> GetAllClients()
        {
            _logger.ForContext("Source", typeof(ClientRepository).FullName)
                .ForContext("MethodName", GetActualAsyncMethodName())
                .Information("Get all clients from database");

            IList<Client> clients;

            clients = await _dbContext.Client?.ToListAsync();

            _logger.Debug("GetAllClients completed successfully. total clients returned {Clients}", clients.Count);

            return clients;
        }

        public async Task<IList<Client>> GetClients(List<int> ids)
        {
            _logger.ForContext("Source", typeof(ClientRepository).FullName)
                   .ForContext("MethodName", GetActualAsyncMethodName())
                   .Information("Get clients from database for given clientIds: {ClientIds}", ids);


            if (ids == null || ids.Count == 0)
            {
                _logger.Information("No client id provided. Returning null.");
                return null;
            }


            var result = await _dbContext.Client?.Where(x => ids.Contains(x.Idclient))?.ToListAsync();

            _logger.Debug("GetClients return {ResultCount} result.", result?.Count);

            return result;
        }



        public async Task<IList<Client>> GetMRActiveClientsForEnglishLang()
        {
            _logger.ForContext("Source", typeof(ClientRepository).FullName)
                   .ForContext("MethodName", GetActualAsyncMethodName())
                   .Information("Get active MR clients for english language from database.");

            IList<Client> clients = null;
            Stopwatch sw = Stopwatch.StartNew();

            if (DataContextSet == null || DataContextSet.Count < 1)
            {
                await PupulateMRDataFromDBContext();
            }

            var res = DataContextSet
                .GroupBy(x => x.Id,
                (id, data) => new { id, langCount = data.Count(), language = data.Select(s => s.lang) })?
                .Where(x => x.language.All(l => l.ToLower() == "en"))?
                .Select(s => s.id);

            clients = await GetClientsfromClientId(res);

            sw.Stop();

            _logger.Debug("GetMRActiveClientsForEnglishLang return {ClientsCount} result. Time taken: {TotalMilliseconds} ms", clients?.Count, sw.ElapsedMilliseconds);
            _logger.Information("GetMRActiveClientsForEnglishLang return {ClientsCount} result.", clients?.Count);

            return clients;
        }

        public async Task<IDictionary<int, DateTime?>> GetMaxEndDeliveryDateForClients(List<int> clientIds)
        {
            _logger.ForContext("Source", typeof(ClientRepository).FullName)
                     .ForContext("MethodName", GetActualAsyncMethodName())
                     .Information("Get max delivery date for clients {ClientIds}", clientIds);

            Dictionary<int, DateTime?> clientExpiryDictionary = null;

            if (clientIds == null || clientIds.Count == 0)
            {
                return null;
            }

            var clientDictionary = await (from client in _dbContext.ClAllClientRegionLang
                                          where clientIds.Contains(client.Idclient) && client.ServiceCode.ToLower() == "mr"
                                          group client by client.Idclient into clientGroup
                                          select new
                                          {
                                              clientId = clientGroup.Key,
                                              MaxEndDate = clientGroup.Max(x => x.EndOfDelivery)
                                          }
                                         )?.ToListAsync();

            if (clientDictionary != null && clientDictionary.Count > 0)
            {
                clientExpiryDictionary = new Dictionary<int, DateTime?>();
            }

            foreach (var val in clientDictionary)
            {
                if (val.MaxEndDate.HasValue)
                    clientExpiryDictionary.Add(val.clientId, val.MaxEndDate.Value);
                else
                    clientExpiryDictionary.Add(val.clientId, null);
            }

            _logger.Debug("Max delivery date for clients {ClientExpiryDictionary}", clientExpiryDictionary);

            return clientExpiryDictionary;
        }

        public async Task<IList<Client>> GetMRActiveClientsForTranslatedLang()
        {
            _logger.ForContext("Source", typeof(ClientRepository).FullName)
                    .ForContext("MethodName", GetActualAsyncMethodName())
                    .Information("Get active MR clients for translated language from database.");

            IList<Client> clients = null;
            Stopwatch sw = Stopwatch.StartNew();

            if (DataContextSet == null || DataContextSet.Count < 1)
            {
                await PupulateMRDataFromDBContext();
            }

            var res = DataContextSet
                 .GroupBy(x => x.Id,
                 (id, data) => new { id, langCount = data.Count(), language = data.Select(s => s.lang) })?
                 .Where(x => x.language.Any(l => l.ToLower() != "en"))?
                 .Select(s => s.id);

            clients = await GetClientsfromClientId(res);

            sw.Stop();

            _logger.Debug("GetMRActiveClientsForTranslatedLang return {ClientsCount} result. Time taken: {TotalMilliseconds} ms", clients?.Count, sw.ElapsedMilliseconds);
            _logger.Information("GetMRActiveClientsForTranslatedLang return {ClientsCount} result.", clients?.Count);

            return clients;
        }



        public async Task<int> UpdateLatestReportDateForClients(List<Client> clients)
        {
            _logger.ForContext("Source", typeof(ClientRepository).FullName)
                    .ForContext("MethodName", GetActualAsyncMethodName())
                    .Information("Update latest report date for clients in database. {ClientIds} to update", clients.Any() ? string.Join(',', clients.Select(c => c.Idclient).ToList()) : string.Empty);

            int result = 0;

            Stopwatch sw = Stopwatch.StartNew();

            if (clients != null && clients.Count > 0)
            {
                foreach (var client in clients)
                {
                    _dbContext.Attach(client);
                    _dbContext.Entry(client).Property("LatestReportDate").IsModified = true;

                }

                result = await _dbContext.SaveChangesAsync();
            }

            sw.Stop();

            _logger.Debug("UpdateLatestReportDateForClients return {Result} result.Time taken: {TotalMilliseconds} ms", result, sw.Elapsed.TotalMilliseconds);
            _logger.Debug("UpdateLatestReportDateForClients return {Result} result.", result);

            return result;
        }

        private async Task PupulateMRDataFromDBContext()
        {

            DataContextSet = await (from client in _dbContext.Client
                                    join cl_client in _dbContext.ClAllClientRegionLang on client.Idclient equals cl_client.Idclient
                                    where cl_client.ServiceCode.ToLower() == "mr"
                                    && client.Status == 0
                                    && (cl_client.EndOfDelivery >= DateTime.Now || cl_client.EndOfDelivery == null)
                                    select new MrDataContext { Id = cl_client.Idclient, lang = cl_client.LanguageCode, client = client })?
                                    .ToListAsync();

            var clientsWithUsers = await _dbContext.TblDirepce.Where(t => t.Email != null && t.SIndex != "A")
                .Select(s => s.Idclient)
                .Distinct()
                .ToListAsync();

            DataContextSet = DataContextSet.Where(d => clientsWithUsers.Contains(d.Id)).ToList();

        }
        private async Task<IList<Client>> GetClientsfromClientId(IEnumerable<int> res)
        {
            if (res == null || res.Any() == false || DataContextSet == null || DataContextSet.Any() == false)
                return null;

            return await Task.FromResult(DataContextSet
                .Where(x => res.Contains(x.client.Idclient))?
                .Select(c => c.client)?
                .GroupBy(s => s.Idclient)?
                .Select(s => s.First())?
                .ToList());
        }

        public class MrDataContext
        {
            public int Id { get; set; }
            public string lang { get; set; }
            public Client client { get; set; }
        }
    }
}
