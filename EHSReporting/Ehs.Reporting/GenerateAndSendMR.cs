using Ehs.Reporting.MR.Services.Interface;
using Serilog;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static Ehs.Reporting.MR.AppArgs;

namespace Ehs.Reporting.MR.Infrastructure
{
    public class GenerateAndSendMR : IApplication
    {
        private readonly ILogger _logger;
        private readonly GenerateAndSendMROptions _options;
        private IApplicationService _applicationService;

        public GenerateAndSendMR(GenerateAndSendMROptions options,
            ILogger logger,
            IApplicationService applicationService)
         {
            _logger = logger;
            _options = options;
            _applicationService = applicationService;
        }

        static string GetActualAsyncMethodName([CallerMemberName]string name = null) => name;

        public async Task<int> Run()
        {
            int result = 0;
            _logger.ForContext("Source", typeof(GenerateAndSendMR).FullName)
                   .ForContext("MethodName", GetActualAsyncMethodName())
                   .Information("Run GenerateAndSendMR with options:{SendEmailToUsers} {Type}.", _options.ShouldSendEmail, _options.Type);

            if (!string.IsNullOrEmpty(_options.Type) && _options.ShouldSendEmail.HasValue)
            {
                switch (_options.Type.ToLower())
                {
                    case "all":
                        {
                            _logger.Debug("Handling all client types.");
                            result = await _applicationService.HandleAllClients(_options.ShouldSendEmail.Value);

                            break;
                        }
                    case "englishonly":
                        {
                            _logger.Debug("Handling english only client types.");
                            result = await _applicationService.HandleEnglishOnlyClients(_options.ShouldSendEmail.Value);

                            break;
                        }
                    case "translatedonly":
                        {
                            _logger.Debug("Handling translated only client types.");
                            result = await _applicationService.HandleTranslatedClients(_options.ShouldSendEmail.Value);

                            break;
                        }
                    default:
                        {
                            _logger.Information("GenerateAndSendMR: No correct option is provided to execute this job. Process will stop.");
                            break;
                        }
                }

                _logger.Information("GenerateAndSendMR execution Completed.");
            }
            else
            {
                _logger.Information("GenerateAndSendMR: No value provided for 'Type(t)' or 'ShouldSendEmail(s)' runtime parameters. Process will stop.");

            }

            return await Task.FromResult(result);

        }
    }
}
