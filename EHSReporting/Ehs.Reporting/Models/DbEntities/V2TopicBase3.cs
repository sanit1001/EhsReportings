using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class V2TopicBase3
    {
        public int Idtopic { get; set; }
        public string CountryCode { get; set; }
        public int? Idstatus { get; set; }
        public int? RegCitationlinked { get; set; }
        public DateTime? AdoptionDate { get; set; }
        public int? Idcontact { get; set; }
        public DateTime? ReportDate { get; set; }
        public string InternalCode { get; set; }
        public string Idproduct { get; set; }
        public bool Archived { get; set; }
        public string ArchivedBy { get; set; }
        public DateTime? DateArchived { get; set; }
        public string ContactType { get; set; }
        public string BaseLanguageCode { get; set; }
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
