using System;
using System.Collections.Generic;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryRegulationMonitoringReport
    {
        public HistoryRegulationMonitoringReport()
        {
            TrackingRegulationMonitoringReport = new HashSet<TrackingRegulationMonitoringReport>();
        }

        public int RegId { get; set; }
        public int Idtopic { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }

        public virtual ICollection<TrackingRegulationMonitoringReport> TrackingRegulationMonitoringReport { get; set; }
    }
}
