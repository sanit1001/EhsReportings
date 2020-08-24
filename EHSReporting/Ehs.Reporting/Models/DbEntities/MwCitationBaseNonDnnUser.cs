using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MwCitationBaseNonDnnUser
    {
        public int Idcitation { get; set; }
        public string HAutoId { get; set; }
        public string TAutoId { get; set; }
        public string PkAutoId { get; set; }
        public int RegId { get; set; }
        public string BaseLanguageCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public string SortOrder { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string RowStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte MajorVersion { get; set; }
        public byte MinorVersion { get; set; }
        public byte RevisionNumber { get; set; }
        public string VersionNumber { get; set; }
        public int UpdateTypeId { get; set; }
        public string ChangeNotes { get; set; }
        public string ChangedBy { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
        public DateTime NewStartDate { get; set; }
        public bool? IsContracted { get; set; }
        public bool? IsOfInterest { get; set; }
    }
}
