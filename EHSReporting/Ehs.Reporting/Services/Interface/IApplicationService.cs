using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ehs.Reporting.MR.Services.Interface
{
    public interface IApplicationService
    {
        Task<int> HandleAllClients(bool shouldSendEmail);
        Task<int> HandleEnglishOnlyClients(bool shouldSendEmail);
        Task<int> HandleTranslatedClients(bool shouldSendEmail);
        Task<int> HandleForClientIds(List<int> clientIds, bool shouldSendEmail);
        Task<int> HandleForClientUserIds(int clientId, List<string> userIds, bool shouldSendEmail);
    }
}
