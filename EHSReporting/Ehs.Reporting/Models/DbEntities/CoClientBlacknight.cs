using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoClientBlacknight
    {
        public int Idclient { get; set; }
        public string ClientName { get; set; }
        public DateTime? DateWebsiteLastChecked { get; set; }
        public bool HasWebsite { get; set; }
        public DateTime DateMoved { get; set; }
        public string HttpResponse { get; set; }
    }
}
