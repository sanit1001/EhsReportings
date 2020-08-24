using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkRegulationMonitoringReport
    {
        public int RegId { get; set; }
        public int Idtopic { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
