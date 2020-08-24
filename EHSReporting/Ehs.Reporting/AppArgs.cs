using System;
using System.Collections.Generic;
using System.Text;
using CommandLine;

namespace Ehs.Reporting.MR
{
    public class AppArgs
    {
        [Verb("init", isDefault: true, HelpText = "Generate and Send MR reports.")]
        public class GenerateAndSendMROptions
        {
            [Option(shortName: 't', longName: "executionType", Required = true, HelpText = "This is a required field. Run for ExecutionTypes: 'all', 'englishOnly' & 'translatedOnly'")]
            public string Type { get; set; }

            [Option(shortName: 's', longName: "sendEmail", Required = true, HelpText = "This is a required field. 'false' to not send an e-mail to any user.")]
            public bool? ShouldSendEmail { get; set; }
        }

        [Verb("client", isDefault: false, HelpText = "Generate and Send MR reports for specific clients only.")]
        public class GenerateAndSendMRForClientOptions
        {
            [Option(shortName: 'c', longName: "client", Required = true, HelpText = "This is a required field. Run for specific list of clients only. separate multiple client ids with ' '.", Separator = ' ')]
            public IEnumerable<string> ClientIds { get; set; }

            [Option(shortName: 's', longName: "sendEmail", Required = true, HelpText = "This is a required field. 'false' to not send an e-mail to any user.")]
            public bool? ShouldSendEmail { get; set; }
        }

        [Verb("clientUser", isDefault: false, HelpText = "Generate and Send MR reports for specific client users only. Only one client with multiple user email ids are supported.")]
        public class GenerateAndSendMRForClientUserOptions
        {
            [Option(shortName: 'c', longName: "client", Required = true, HelpText = "Run for a specific client only.")]
            public string ClientId { get; set; }

            [Option(shortName: 'u', longName: "userEmailIds", Required = true, HelpText = "User email ids for one specific client. Please separate user email ids with ' '.", Separator = ' ')]
            public IEnumerable<string> UserEmailIds { get; set; }

            [Option(shortName: 's', longName: "sendEmail", Required = true, HelpText = "This is a required field. 'false' to not send an e-mail to any user.")]
            public bool? ShouldSendEmail { get; set; }
        }
    }
}
