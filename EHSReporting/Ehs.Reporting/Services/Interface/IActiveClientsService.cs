using Ehs.Reporting.MR.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ehs.Reporting.MR.Services
{
    public interface IActiveClientsService
    {
        Task<List<Client>> GetActiveClients();

        Task<IList<Client>> GetActiveMRClientsForEnglishLang();

        Task<IList<Client>> GetActiveMRClientsForTranslatedLang();

        Task<List<Client>> UpdateLatestMRReportDateForClients(List<Client> clients);

        Task<List<Client>> UpdateLatestMRReportDateForTranslatedClients(List<Client> clients);
    }
}
