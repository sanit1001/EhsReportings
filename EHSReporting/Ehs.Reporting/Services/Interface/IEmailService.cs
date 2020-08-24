using Ehs.Reporting.MR.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ehs.Reporting.MR.Services
{
    public interface IEmailService
    {
        Task<int> SendBulkAsync(IList<ResponseModel> recipients, int batchSize);
        Task<int> SendBulkAsync(ResponseModel recipient, int batchSize);
    }
}
