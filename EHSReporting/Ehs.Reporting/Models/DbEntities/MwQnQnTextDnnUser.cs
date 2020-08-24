using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MwQnQnTextDnnUser
    {
        public Guid RowId { get; set; }
        public string QnCode { get; set; }
        public string LanguageCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public int SortCode { get; set; }
        public string HeadingCode { get; set; }
        public bool Timing { get; set; }
        public bool IsException { get; set; }
        public string Note { get; set; }
        public bool IsRevised { get; set; }
        public bool IsForOffices { get; set; }
        public bool Archived { get; set; }
        public bool? IsForWarehouses { get; set; }
        public string BaseLanguageCode { get; set; }
        public DateTime LastModifiedDateBaseLanguage { get; set; }
        public bool IsRto { get; set; }
        public string ReleaseNote { get; set; }
        public string ArchivedBy { get; set; }
        public DateTime? DateArchived { get; set; }
        public string ReleaseComment { get; set; }
        public string Md5 { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string RowStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte MajorVersion { get; set; }
        public byte MinorVersion { get; set; }
        public byte RevisionNumber { get; set; }
        public string VersionNumber { get; set; }
        public int TrackingQnUpdateTypeId { get; set; }
        public string TrackingQnChangeNotes { get; set; }
        public string TrackingQnChangedBy { get; set; }
        public int TrackingQnTextUpdateTypeId { get; set; }
        public string TrackingQnTextChangeNotes { get; set; }
        public string TrackingQnTextChangedBy { get; set; }
        public string Qn { get; set; }
        public string QnGuideNote { get; set; }
        public DateTime? ValidityDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? QcedDate { get; set; }
        public DateTime? ProofedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string QcedBy { get; set; }
        public string Documents { get; set; }
        public string ProofedBy { get; set; }
        public byte? Status { get; set; }
        public string QnTitle { get; set; }
    }
}
