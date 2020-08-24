using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryAmendmentMonitoringReport
    {
        public int Idtopic { get; set; }
        public string AmendmentCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
