using Ehs.Reporting.MR.Services.Interface;
using Serilog;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static Ehs.Reporting.MR.AppArgs;

namespace Ehs.Reporting.MR.Infrastructure
{
    public class GenerateAndSendMRForClientUser : IApplication
    {

        private readonly ILogger _logger;
        private readonly GenerateAndSendMRForClientUserOptions _options;
        private readonly IApplicationService _applicationService;

        public GenerateAndSendMRForClientUser(ILogger logger, GenerateAndSendMRForClientUserOptions options, IApplicationService applicationService)
        {
            _options = options;
            _logger = logger;
            _applicationService = applicationService;

        }
        static string GetActualAsyncMethodName([CallerMemberName]string name = null) => name;

        public async Task<int> Run()
        {
            int result = 0;
            _logger.ForContext("Source", typeof(GenerateAndSendMRForClientUser).FullName)
                   .ForContext("MethodName", GetActualAsyncMethodName())
                   .Information("Run GenerateAndSendMRForClientUser with options:{SendEmailToUsers} {ClientId} {UserEmailIds}.", _options.ShouldSendEmail, _options.ClientId, string.Join(',', _options.UserEmailIds));


            if (_options.ClientId != null && _options.UserEmailIds != null
                && _options.UserEmailIds.ToList().Any()
                && _options.ShouldSendEmail.HasValue)
            {
                result = await _applicationService.HandleForClientUserIds(Convert.ToInt32(_options.ClientId), _options.UserEmailIds.ToList(), _options.ShouldSendEmail.Value);
            }
            else
            {
                _logger.Information("GenerateAndSendMRForClientUser: no values provided for: 'ClientId(c)' or 'UserEmailIds(u)' or 'ShouldSendEmail(s)'. Process will stop.");

            }

            return await Task.FromResult(result);
        }
    }
}


