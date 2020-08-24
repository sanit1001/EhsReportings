using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MonitoringReport
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
        public string LanguageCode { get; set; }
        public string Topic { get; set; }
        public string Rapid { get; set; }
        public string Summary { get; set; }
        public string ArchiveReference { get; set; }
        public string IssuingAuthority { get; set; }
        public string EnforcingAuthority { get; set; }
        public string RegulatoryCitation { get; set; }
        public string LegislationRepealed { get; set; }
        public string AffectedOperations { get; set; }
        public int? AuthorId { get; set; }
        public string AuthorInformation { get; set; }
        public string RegulatoryText { get; set; }
        public string RapidComments { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateLastModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool ReadyforQc { get; set; }
        public string ReadyforQcby { get; set; }
        public DateTime? ReadyforQcdate { get; set; }
        public bool PrintedforQc { get; set; }
        public string PrintedforQcby { get; set; }
        public DateTime? PrintedforQcdate { get; set; }
        public bool Reviewed { get; set; }
        public string ReviewedBy { get; set; }
        public DateTime? ReviewedDate { get; set; }
        public bool Qc { get; set; }
        public string Qcby { get; set; }
        public DateTime? Qcdate { get; set; }
        public bool ProofRead { get; set; }
        public string ProofReadBy { get; set; }
        public DateTime? ProofReadDate { get; set; }
        public bool Translated { get; set; }
        public DateTime? TranslatedDate { get; set; }
        public bool Sent { get; set; }
        public string SentBy { get; set; }
        public DateTime? SentDate { get; set; }
        public bool ReadyforPublication { get; set; }
        public string ReadyforPublicationBy { get; set; }
        public DateTime? ReadyforPublicationDate { get; set; }
        public Guid RowId { get; set; }
        public string TranslatedBy { get; set; }
    }
}
