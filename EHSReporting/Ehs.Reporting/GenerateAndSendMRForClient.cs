using Ehs.Reporting.MR.Services.Interface;
using Serilog;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static Ehs.Reporting.MR.AppArgs;

namespace Ehs.Reporting.MR.Infrastructure
{
    public class GenerateAndSendMRForClient : IApplication
    {
        private readonly ILogger _logger;
        private readonly GenerateAndSendMRForClientOptions _options;
        private readonly IApplicationService _applicationService;

        public GenerateAndSendMRForClient(ILogger logger, 
            GenerateAndSendMRForClientOptions options,
            IApplicationService applicationService)
        {
            _options = options;
            _logger = logger;
            _applicationService = applicationService;

        }
        static string GetActualAsyncMethodName([CallerMemberName]string name = null) => name;

        public async Task<int> Run()
        {
            int result = 0;
            _logger.ForContext("Source", typeof(GenerateAndSendMRForClient).FullName)
                   .ForContext("MethodName", GetActualAsyncMethodName())
                   .Information("Run GenerateAndSendMRForClient with options:{SendEmailToUsers} {ClientIds}.", _options.ShouldSendEmail, _options.ClientIds);

            if (_options.ClientIds != null && _options.ClientIds.Any() && _options.ShouldSendEmail.HasValue)
            {
                result = await _applicationService.HandleForClientIds(_options.ClientIds.Select(int.Parse).ToList(), _options.ShouldSendEmail.Value);
            }
            else
            {
                _logger.Information("GenerateAndSendMRForClient: no values provided for: 'ClientIds(c)' or 'ShouldSendEmail(s)'. Process will stop.");
            }

            return await Task.FromResult(result);
        }
    }
}
