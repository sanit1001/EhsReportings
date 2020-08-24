using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ehs.Reporting.MR.Services.Contracts
{
    public class MailingListModel
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EmailSubject { get; set; }
        public string EmailURL { get; set; }
        public string EmailBody { get; set; }
    }
}
