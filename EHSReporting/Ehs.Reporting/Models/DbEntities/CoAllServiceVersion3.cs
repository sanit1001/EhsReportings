using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoAllServiceVersion3
    {
        public string ServiceCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string LanguageCode { get; set; }
        public string SetCode { get; set; }
        public int IndCode { get; set; }
        public string ProductTypeCode { get; set; }
        public float? RepCode { get; set; }
        public DateTime? ExpectedPublicationDate { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public short AvailableItemCount { get; set; }
        public short NotIncludedCount { get; set; }
        public bool? Fake { get; set; }
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
