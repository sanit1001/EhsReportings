using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoAllClientReportDates
    {
        public int Idclient { get; set; }
        public string ClientName { get; set; }
        public DateTime? EarliestReportDate { get; set; }
        public DateTime? MaxOfClientReportDate { get; set; }
        public string ClientLongName { get; set; }
        public DateTime? LatestReportDate { get; set; }
        public string UseSnapshotDb { get; set; }
        public string UseServerInstance { get; set; }
        public int IdcontentProxy { get; set; }
        public int IdservicesProxy { get; set; }
    }
}
