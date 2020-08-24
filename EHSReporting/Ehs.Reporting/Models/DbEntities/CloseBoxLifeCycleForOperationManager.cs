using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CloseBoxLifeCycleForOperationManager
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string ServiceCode { get; set; }
        public string LanguageCode { get; set; }
        public string SetCode { get; set; }
        public int IndCode { get; set; }
        public float? RepCode { get; set; }
        public string RowStatus { get; set; }
        public DateTime NewResearchDate { get; set; }
        public DateTime? ExpectedPublicationDate { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
        public DateTime StartDate { get; set; }
        public string ChangedBy { get; set; }
        public string TeamLeader { get; set; }
        public string TlEmail { get; set; }
    }
}
