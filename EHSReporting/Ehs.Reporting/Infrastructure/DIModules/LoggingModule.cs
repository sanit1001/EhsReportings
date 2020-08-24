using Autofac;
using Ehs.Reporting.MR.Infrastructure.Formatters;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Debugging;
using Serilog.Events;
using System;

namespace Ehs.Reporting.MR.Infrastructure
{
    public class LoggingModule : Module
    {
        private readonly IConfiguration _config;
        public LoggingModule(IConfiguration config)
        {
            _config = config;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context =>
            {
                var serviceName = _config.GetValue<string>("logging:serviceName") ?? "MRReportingTool";
                var isConsoleEnabled = IsTrue(_config.GetValue<string>("logging:sinks:console:enabled"));
                var isSplunkEnabled = IsTrue(_config.GetValue<string>("logging:sinks:splunk:enabled"));

                var defaultLogLevel = LogEventLevel.Debug;

                var loggerConfiguration = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .Enrich.WithProperty("Service", serviceName)
                .Enrich.WithThreadId()
                .Enrich.FromLogContext()
                .Enrich.WithCorrelationId();

                if (isConsoleEnabled)
                    loggerConfiguration
                        .WriteTo
                        .Console(string.IsNullOrWhiteSpace(_config.GetValue<string>("logging:sinks:console:minimumLevel"))
                        ? defaultLogLevel : ParseLogLevel(_config.GetValue<string>("logging:sinks:console:minimumLevel")).Value);

                if (isSplunkEnabled)
                {
                    var minimumLogLevel = string.IsNullOrWhiteSpace(_config.GetValue<string>("logging:sinks:splunk:minimumLevel"))
                    ? defaultLogLevel : ParseLogLevel(_config.GetValue<string>("logging:sinks:splunk:minimumLevel")).Value;

                    loggerConfiguration
                    .WriteTo
                    .EventCollector(_config.GetValue<string>("logging:sinks:splunk:host"),
                    _config.GetValue<string>("logging:sinks:splunk:eventCollectorToken"),
                    new SplunkJsonFormatter(minimumLogLevel <= defaultLogLevel),
                    restrictedToMinimumLevel: minimumLogLevel);

                    SelfLog.Enable(Console.Error);
                    SelfLog.Enable(s =>
                    {
                        Console.WriteLine($"Serilog ERROR: {s}");
                    });
                }

                Log.Logger = loggerConfiguration.CreateLogger();
                return Log.Logger;
            })
                .As<Serilog.ILogger>()
                .SingleInstance();
        }

        private bool IsTrue(string text)
        {
            bool isTrue = false;
            if (!string.IsNullOrEmpty(text))
                isTrue = string.Equals(text, bool.TrueString, StringComparison.InvariantCultureIgnoreCase);

            return isTrue;
        }

        private LogEventLevel? ParseLogLevel(string minimumLevel)
        {
            var parsed = Enum.TryParse(minimumLevel, out LogEventLevel parsedValue);
            var minimumLogLevel = parsed ? parsedValue : null as LogEventLevel?;
            return minimumLogLevel;
        }
    }
}
