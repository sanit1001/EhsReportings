namespace Ehs.Reporting.MR.Models
{
    public partial class AllRegulationLatinAmericaAndSppt
    {
        public int RegId { get; set; }
        public bool Effective { get; set; }
        public bool Archive { get; set; }
        public string LanguageCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string CreateDate { get; set; }
        public string LastModifiedDate { get; set; }
        public string RegHyperlink { get; set; }
        public string ConsolidatedHyperlink { get; set; }
        public string RegTitle { get; set; }
        public string RegSummary { get; set; }
        public string MainRequirements { get; set; }
        public string IndustrySector { get; set; }
    }
}
