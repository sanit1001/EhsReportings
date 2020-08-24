using System;
using System.Collections.Generic;

namespace Ehs.Reporting.MR.Models
{
    public partial class TrackingV2ImplementationText
    {
        public TrackingV2ImplementationText()
        {
            InverseTrackingV2ImplementationTextNavigation = new HashSet<TrackingV2ImplementationText>();
        }

        public int Idimplementation { get; set; }
        public string LanguageCode { get; set; }
        public DateTime NewResearchDate { get; set; }
        public Guid RowId { get; set; }
        public string RowStatus { get; set; }
        public int UpdateTypeId { get; set; }
        public string ChangeNotes { get; set; }
        public string ChangedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LanguageCodeBase { get; set; }
        public DateTime StartDateBase { get; set; }
        public byte MajorVersion { get; set; }
        public byte MinorVersion { get; set; }
        public byte RevisionNumber { get; set; }
        public string VersionNumber { get; set; }

        public virtual HistoryV2ImplementationText HistoryV2ImplementationText { get; set; }
        public virtual CoAllWorkflowStatus RowStatusNavigation { get; set; }
        public virtual TrackingV2ImplementationText TrackingV2ImplementationTextNavigation { get; set; }
        public virtual CoAllUpdateType UpdateType { get; set; }
        public virtual ICollection<TrackingV2ImplementationText> InverseTrackingV2ImplementationTextNavigation { get; set; }
    }
}
