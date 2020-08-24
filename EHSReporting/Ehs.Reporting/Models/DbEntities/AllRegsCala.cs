using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class AllRegsCala
    {
        public int RegId { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public bool Active { get; set; }
        public bool Archive { get; set; }
        public string RegTitle { get; set; }
        public string RegSummary { get; set; }
        public string MainRequirements { get; set; }
        public string RegHyperlink { get; set; }
        public string ConsolidatedHyperlink { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public string RegulationReference { get; set; }
        public string Title { get; set; }
        public DateTime NewResearchDate { get; set; }
        public DateTime ResearchDate { get; set; }
        public int? IssuingAuthority { get; set; }
        public string LanguageCode { get; set; }
        public string VersionNumber { get; set; }
        public string ChangeNotes { get; set; }
        public string ChangeType { get; set; }
        public string CountryCode { get; set; }
        public string IndName { get; set; }
    }
}
