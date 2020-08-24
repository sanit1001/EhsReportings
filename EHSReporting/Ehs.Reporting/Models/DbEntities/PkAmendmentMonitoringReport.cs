using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkAmendmentMonitoringReport
    {
        public int Idtopic { get; set; }
        public string AmendmentCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
