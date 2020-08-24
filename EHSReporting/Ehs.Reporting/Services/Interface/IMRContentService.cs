using Ehs.Reporting.MR.Models;
using Ehs.Reporting.MR.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ehs.Reporting.MR.Services
{
    public interface IMRContentService
    {
        Task<List<ResponseModel>> GetMRContentForClients(List<Client> clientId);
        Task<ResponseModel> GetMRUsersForClient(Client clientId);
        Task<ResponseModel> GetEmailContentForUsers(ResponseModel model);
    }
}
