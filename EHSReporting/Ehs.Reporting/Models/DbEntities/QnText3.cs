using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class QnText3
    {
        public string QnCode { get; set; }
        public string LanguageCode { get; set; }
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
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public DateTime NewResearchDate { get; set; }
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
        public DateTime LastPublishedStartDate { get; set; }
        public DateTime NewStartDate { get; set; }
        public bool? IsContracted { get; set; }
        public bool? IsOfInterest { get; set; }
    }
}
