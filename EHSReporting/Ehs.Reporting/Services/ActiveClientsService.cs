using Ehs.Reporting.MR.Models;
using Ehs.Reporting.MR.Repository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Ehs.Reporting.MR.Services
{
    public class ActiveClientsService : IActiveClientsService
    {
        private readonly IClientRepository _clientRepository;
        private readonly ILogger _logger;
        public ActiveClientsService(IClientRepository clientRepo, ILogger logger)
        {
            _clientRepository = clientRepo;
            _logger = logger;

        }
        static string GetActualAsyncMethodName([CallerMemberName]string name = null) => name;
        public async Task<List<Client>> GetActiveClients()
        {
            _logger.ForContext("Source", typeof(ClientRepository).FullName)
               .ForContext("MethodName", GetActualAsyncMethodName())
               .Information("Get all active clients.");

            var allClients = await _clientRepository.GetAllClients();

            _logger.Debug("Total clients returned from repository: {Count}", allClients.Count);

            List<Client> activeClients = null;
            if (allClients.Any())
            {
                activeClients = allClients.Where(x => x.Idclient > 0 && x.Status == 0)?.ToList();
            }

            _logger.Information("Total active clients count: {ActiveClientsCount}", activeClients.Any() ? activeClients.Count : 0);

            return activeClients;
        }

        public async Task<IList<Client>> GetActiveMRClientsForEnglishLang()
        {
            _logger.ForContext("Source", typeof(ClientRepository).FullName)
               .ForContext("MethodName", GetActualAsyncMethodName())
               .Information("Get active MR clients for English language.");

            return await _clientRepository.GetMRActiveClientsForEnglishLang();
        }

        public async Task<IList<Client>> GetActiveMRClientsForTranslatedLang()
        {
            _logger.ForContext("Source", typeof(ClientRepository).FullName)
               .ForContext("MethodName", GetActualAsyncMethodName())
               .Information("Get active MR clients for translated language.");

            return await _clientRepository.GetMRActiveClientsForTranslatedLang();
        }

        public async Task<List<Client>> UpdateLatestMRReportDateForClients(List<Client> clients)
        {
            _logger.ForContext("Source", typeof(ClientRepository).FullName)
              .ForContext("MethodName", GetActualAsyncMethodName())
              .Information("Update latest MR report date for clients. {ClientIds}", clients.Any() ? string.Join(',', clients.Select(c => c.Idclient).ToList()) : string.Empty);

            if (clients == null || clients.Count == 0)
                return null;

            var retVal = await _clientRepository.GetMaxEndDeliveryDateForClients(clients.Select(x => x.Idclient).ToList());

            _logger.Debug("GetMaxEndDeliveryDateForClients returns endContractDate from DB: {RetValCount}", retVal);

            if (retVal == null || retVal.Count == 0)
                return null;

            var modifiedClients = new List<Client>();

            foreach (var client in clients)
            {
                if (retVal.ContainsKey(client.Idclient)
                        && retVal[client.Idclient].HasValue)
                {
                    var endcontractMaxDate = retVal[client.Idclient].Value;

                    if (client.LatestReportDate.HasValue)
                    {
                        if (endcontractMaxDate >= client.LatestReportDate)
                        {
                            client.LatestReportDate = endcontractMaxDate;
                            modifiedClients.Add(client);
                        }
                    }
                    else
                    {
                        client.LatestReportDate = endcontractMaxDate;
                        modifiedClients.Add(client);

                    }
                }
            }

            if (modifiedClients.Count > 0)
            {
                _logger.Information("English only clients to adjust LatestReportDate are: {ModifiedClients}", modifiedClients?.Select(x => new { x.Idclient, x.LatestReportDate }));

                var updateCount = await _clientRepository.UpdateLatestReportDateForClients(modifiedClients);

                _logger.Debug("Total records updated successfully are: {UpdateCount}", updateCount);

                return clients;
            }
            else
            {
                _logger.Information("There are no changes to save.");
            }

            return null;
        }

        public async Task<List<Client>> UpdateLatestMRReportDateForTranslatedClients(List<Client> clients)
        {
            _logger.ForContext("Source", typeof(ClientRepository).FullName)
              .ForContext("MethodName", GetActualAsyncMethodName())
              .Information("Update latest MR report date for translated clients. {ClientIds}", clients.Any() ? string.Join(',', clients.Select(c => c.Idclient).ToList()) : string.Empty);

            if (clients == null || clients.Count == 0)
                return null;

            var previousDateTime = CalculateLastMonthDateTime();

            var modifiedClients = new List<Client>();

            foreach (var client in clients)
            {
                if (client.LatestReportDate == null
                    || (client.LatestReportDate.HasValue && client.LatestReportDate != previousDateTime))
                {
                    client.LatestReportDate = previousDateTime;
                    modifiedClients.Add(client);
                }
            }

            if (modifiedClients.Count > 0)
            {
                _logger.Information("Translated clients to adjust LatestReportDate are: {ModifiedClients}", modifiedClients?.Select(x => new { x.Idclient, x.LatestReportDate }));

                var updateCount = await _clientRepository.UpdateLatestReportDateForClients(modifiedClients);

                _logger.Debug("Total records updated successfully are: {UpdateCount}", updateCount);

                return clients;
            }

            return null;
        }

        private DateTime CalculateLastMonthDateTime()
        {
            DateTime previousDate = DateTime.Now.AddMonths(-1);

            return new DateTime(previousDate.Year, previousDate.Month, 15);
        }

    }
}
