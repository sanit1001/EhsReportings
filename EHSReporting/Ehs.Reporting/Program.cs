using Autofac;
using Autofac.Extensions.DependencyInjection;
using CommandLine;
using Ehs.Reporting.MR.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using static Ehs.Reporting.MR.AppArgs;

namespace Ehs.Reporting.MR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = BuildModules();

            var logger = container.Resolve<ILogger>();
            try
            {
                IApplication app = null;

                Parser.Default
                    .ParseArguments<GenerateAndSendMROptions, GenerateAndSendMRForClientOptions, GenerateAndSendMRForClientUserOptions>(args)
                    .MapResult(
                    (GenerateAndSendMROptions opts) => app = container.Resolve<GenerateAndSendMR>(new TypedParameter(typeof(GenerateAndSendMROptions), opts)),
                    (GenerateAndSendMRForClientOptions opts) => app = container.Resolve<GenerateAndSendMRForClient>(new TypedParameter(typeof(GenerateAndSendMRForClientOptions), opts)),
                    (GenerateAndSendMRForClientUserOptions opts) => app = container.Resolve<GenerateAndSendMRForClientUser>(new TypedParameter(typeof(GenerateAndSendMRForClientUserOptions), opts)),
                    errors => throw new Exception(errors.ToString())
                    );

                var result = app.Run().GetAwaiter().GetResult();
                logger.Debug("Process ended with {result}.", result);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GlobalExceptionHandler ClassName:{ClassName} MethodName:{MethodName} An Exception has occured. program  will terminate.", Assembly.GetExecutingAssembly().GetName().Name, GetActualAsyncMethodName());
                throw;
            }

            AppDomain.CurrentDomain.ProcessExit += (s, e) => Log.CloseAndFlush();

        }
        static string GetActualAsyncMethodName([CallerMemberName]string name = null) => name;

        private static IConfiguration BuildConfiguration()
        {
            var environmentName = Environment.GetEnvironmentVariable("ENVIRONMENT");

            // build configuration
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("app-settings.json", false, true)
                .AddJsonFile($"app-settings.{environmentName}.json", true)
                .AddEnvironmentVariables()
                .Build();
        }

        private static IContainer BuildModules()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddHttpClient();

            var builder = new ContainerBuilder();
            var configuration = BuildConfiguration();

            builder.RegisterModule(new LoggingModule(configuration));
            builder.RegisterModule(new MRModule(configuration));

            builder.Populate(serviceCollection);

            return builder.Build();

        }
    }
}
