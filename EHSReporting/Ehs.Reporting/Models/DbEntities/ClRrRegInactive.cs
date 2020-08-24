using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClRrRegInactive
    {
        public string LanguageCodeHeadings { get; set; }
        public string HeadingCode { get; set; }
        public int RegId { get; set; }
        public int RegulationType { get; set; }
        public string CountryCode { get; set; }
        public string LanguageCodeRegulations { get; set; }
        public DateTime ValidityDate { get; set; }
        public string RegionCode { get; set; }
        public string RegulationReference { get; set; }
        public string SortCode { get; set; }
        public string RegTitle { get; set; }
        public string RegSummary { get; set; }
        public string MainRequirements { get; set; }
        public string HeadingName { get; set; }
        public string RegHyperlink { get; set; }
        public string ConsolidatedHyperlink { get; set; }
        public int Idclient { get; set; }
        public DateTime CreateDate { get; set; }
        public byte RegMajorVersion { get; set; }
    }
}
