using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class BiMrStatuses
    {
        public int Idtopic { get; set; }
        public int Idclient { get; set; }
        public DateTime? ClientReportDate { get; set; }
        public string BilanguageCode { get; set; }
        public DateTime? BicreateDate { get; set; }
        public DateTime? BidateLastModified { get; set; }
        public DateTime BinewResearchDate { get; set; }
        public string BirowStatus { get; set; }
        public string MrrowStatus { get; set; }
        public DateTime? MrreportDate { get; set; }
    }
}
