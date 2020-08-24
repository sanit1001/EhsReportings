using System;
using System.Collections.Generic;

namespace Ehs.Reporting.MR.Models
{
    public partial class TrackingV2TopicText
    {
        public TrackingV2TopicText()
        {
            InverseTrackingV2TopicTextNavigation = new HashSet<TrackingV2TopicText>();
        }

        public int Idtopic { get; set; }
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

        public virtual HistoryV2TopicText HistoryV2TopicText { get; set; }
        public virtual CoAllWorkflowStatus RowStatusNavigation { get; set; }
        public virtual TrackingV2TopicText TrackingV2TopicTextNavigation { get; set; }
        public virtual CoAllUpdateType UpdateType { get; set; }
        public virtual ICollection<TrackingV2TopicText> InverseTrackingV2TopicTextNavigation { get; set; }
    }
}
