using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ehs.Reporting.MR.Services.Contracts
{
    public class ResponseModel
    {
        [JsonProperty("query")]
        public string Query { get; set; }
        public string IDClient { get; set; }
        [JsonProperty("clientName")]
        public string ClientName { get; set; }
        [JsonProperty("mailingList")]
        public List<MailingListModel> MailingList { get; set; }
        public ResponseModel()
        {
            this.MailingList = new List<MailingListModel>();
        }
    }
}
