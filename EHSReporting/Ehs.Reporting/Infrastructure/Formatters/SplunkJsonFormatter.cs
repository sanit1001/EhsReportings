using Ehs.Reporting.MR.Helpers.Extensions;
using Serilog.Events;
using Serilog.Formatting;
using Serilog.Formatting.Json;
using Serilog.Parsing;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Ehs.Reporting.MR.Infrastructure.Formatters
{
    public class SplunkJsonFormatter : ITextFormatter
    {
        private static readonly JsonValueFormatter ValueFormatter = new JsonValueFormatter(typeTagName: "$type");
        private readonly string _suffix;
        private readonly bool _debugLevel;

        /// <summary>
        /// Construct a <see cref="SplunkJsonFormatter"/>.
        /// </summary>
        /// <param name="source">The source of the event</param>
        /// <param name="sourceType">The source type of the event</param>
        /// <param name="host">The host of the event</param>
        /// <param name="index">The Splunk index to log to</param>
        /// <param name="debugLevel">If true, exception details will be logged.</param>
        public SplunkJsonFormatter(bool debugLevel, string source = null, string sourceType = null, string host = null, string index = null)
        {
            _debugLevel = debugLevel;
            var suffixWriter = new StringWriter();
            suffixWriter.Write("}"); // Terminates "event"

            if (!string.IsNullOrWhiteSpace(source))
            {
                suffixWriter.Write(",\"source\":");
                JsonValueFormatter.WriteQuotedJsonString(source, suffixWriter);
            }

            if (!string.IsNullOrWhiteSpace(sourceType))
            {
                suffixWriter.Write(",\"sourcetype\":");
                JsonValueFormatter.WriteQuotedJsonString(sourceType, suffixWriter);
            }

            if (!string.IsNullOrWhiteSpace(host))
            {
                suffixWriter.Write(",\"host\":");
                JsonValueFormatter.WriteQuotedJsonString(host, suffixWriter);
            }

            if (!string.IsNullOrWhiteSpace(index))
            {
                suffixWriter.Write(",\"index\":");
                JsonValueFormatter.WriteQuotedJsonString(index, suffixWriter);
            }

            suffixWriter.Write('}'); // Terminates the payload
            _suffix = suffixWriter.ToString();
        }

        /// <inheritdoc/>
        public void Format(LogEvent logEvent, TextWriter output)
        {
            if (logEvent == null) throw new ArgumentNullException(nameof(logEvent));
            if (output == null) throw new ArgumentNullException(nameof(output));

            output.Write("{\"time\":\"");
            output.Write(logEvent.Timestamp.ToEpoch().ToString(CultureInfo.InvariantCulture));
            output.Write("\",\"event\":{\"LogLevel\":\"");
            output.Write(logEvent.Level);
            output.Write('"');

            output.Write(",\"Message\":");
            var message = logEvent.MessageTemplate.Render(logEvent.Properties);
            JsonValueFormatter.WriteQuotedJsonString(message, output);

            output.Write(",\"MessageTemplate\":");
            JsonValueFormatter.WriteQuotedJsonString(logEvent.MessageTemplate.Text, output);

            var tokensWithFormat = logEvent.MessageTemplate.Tokens
                    .OfType<PropertyToken>()
                    .Where(pt => pt.Format != null);

            if (tokensWithFormat.Any())
            {
                output.Write(",\"@r\":[");
                var delim = "";
                foreach (var r in tokensWithFormat)
                {
                    output.Write(delim);
                    delim = ",";
                    var space = new StringWriter();
                    r.Render(logEvent.Properties, space);
                    JsonValueFormatter.WriteQuotedJsonString(space.ToString(), output);
                }
                output.Write(']');
            }

            if (logEvent.Exception != null && _debugLevel)
            {
                output.Write(",\"Exception\":");
                JsonValueFormatter.WriteQuotedJsonString(logEvent.Exception.ToString(), output);
            }

            foreach (var property in logEvent.Properties)
            {
                var name = property.Key;
                if (name.Length > 0 && name[0] == '@')
                {
                    // Escape first '@' by doubling
                    name = '@' + name;
                }

                output.Write(',');
                JsonValueFormatter.WriteQuotedJsonString(name, output);
                output.Write(':');
                ValueFormatter.Format(property.Value, output);
            }

            output.WriteLine(_suffix);
        }
    }
}

