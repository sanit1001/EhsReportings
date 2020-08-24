using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TrackingRegulationMonitoringReport
    {
        public int RegId { get; set; }
        public int Idtopic { get; set; }
        public DateTime NewResearchDate { get; set; }
        public Guid RowId { get; set; }
        public string RowStatus { get; set; }
        public int UpdateTypeId { get; set; }
        public string ChangeNotes { get; set; }
        public string ChangedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? StartDateRegId { get; set; }
        public DateTime? StartDateIdtopic { get; set; }
        public byte MajorVersion { get; set; }
        public byte MinorVersion { get; set; }
        public byte RevisionNumber { get; set; }
        public string VersionNumber { get; set; }

        public virtual HistoryRegulationMonitoringReport HistoryRegulationMonitoringReport { get; set; }
        public virtual CoAllWorkflowStatus RowStatusNavigation { get; set; }
        public virtual CoAllUpdateType UpdateType { get; set; }
    }
}
