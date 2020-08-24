using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MwRegulationRegulationTextDnnUser
    {
        public int RegId { get; set; }
        public string LanguageCode { get; set; }
        public string RegTitle { get; set; }
        public string RegSummary { get; set; }
        public string RegHyperlink { get; set; }
        public string ConsolidatedHyperlink { get; set; }
        public string MainRequirements { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime ValidityDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Guid RowId { get; set; }
        public string RepealNote { get; set; }
        public string Md5 { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string RowStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LanguageCodeBase { get; set; }
        public DateTime StartDateBase { get; set; }
        public byte MajorVersion { get; set; }
        public byte MinorVersion { get; set; }
        public byte RevisionNumber { get; set; }
        public string VersionNumber { get; set; }
        public int RegulationType { get; set; }
        public string SortCode { get; set; }
        public bool RegPaperCopy { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public string CountryCode { get; set; }
        public string RegulationReference { get; set; }
        public string RegCode { get; set; }
        public string RegComment { get; set; }
        public bool Effective { get; set; }
        public string ShortAccronym { get; set; }
        public bool Archive { get; set; }
        public string ReasonArchived { get; set; }
        public int? IssuingAuthority { get; set; }
        public DateTime ResearchDate { get; set; }
        public string BaseLanguageCode { get; set; }
        public DateTime? LastModifiedDateBaseLanguage { get; set; }
        public string PublicationReference { get; set; }
        public int MrcoverageType { get; set; }
        public int ApcoverageType { get; set; }
        public string MrcoverageNote { get; set; }
        public string ApcoverageNote { get; set; }
        public bool IsLegislation { get; set; }
        public bool IsEnforced { get; set; }
        public string ArchivedBy { get; set; }
        public DateTime? DateArchived { get; set; }
        public int RegulationTextUpdateTypeId { get; set; }
        public string RegulationTextChangeNotes { get; set; }
        public string RegulationTextChangedBy { get; set; }
        public int RegulationUpdateTypeId { get; set; }
        public string RegulationChangeNotes { get; set; }
        public string RegulationChangedBy { get; set; }
        public bool? IsContracted { get; set; }
        public bool? IsOfInterest { get; set; }
    }
}
