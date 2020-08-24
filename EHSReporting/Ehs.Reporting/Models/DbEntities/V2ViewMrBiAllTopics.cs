using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class V2ViewMrBiAllTopics
    {
        public int Idtopic { get; set; }
        public DateTime? ClientReportDate { get; set; }
        public int Idclient { get; set; }
        public string Importance { get; set; }
        public string ClientName { get; set; }
    }
}
