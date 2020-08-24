using Ehs.Reporting.MR.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ehs.Reporting.MR.Repository
{
    public interface IClientRepository
    {
        Task<IList<Client>> GetAllClients();
        Task<IList<Client>> GetClients(List<int> ids);
        Task<IList<Client>> GetMRActiveClientsForEnglishLang();
        Task<IList<Client>> GetMRActiveClientsForTranslatedLang();
        Task<IDictionary<int, DateTime?>> GetMaxEndDeliveryDateForClients(List<int> clientIds);
        Task<int> UpdateLatestReportDateForClients(List<Client> clients);


    }
}
