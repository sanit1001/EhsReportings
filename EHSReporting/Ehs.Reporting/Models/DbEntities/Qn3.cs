using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class Qn3
    {
        public string QnCode { get; set; }
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
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string RowStatus { get; set; }
        public int UpdateTypeId { get; set; }
        public string ChangeNotes { get; set; }
        public string ChangedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte MajorVersion { get; set; }
        public byte MinorVersion { get; set; }
        public byte RevisionNumber { get; set; }
        public string VersionNumber { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
        public DateTime NewStartDate { get; set; }
        public bool? IsContracted { get; set; }
        public bool? IsOfInterest { get; set; }
    }
}
