namespace Ehs.Reporting.MR.Models
{
    public partial class RegulationWordCounts
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string LanguageCode { get; set; }
        public short? RegSummarytNbrOfWords { get; set; }
        public short? RegMainRequirementNbrOfWords { get; set; }
        public int RegId { get; set; }
        public string HeadingCode { get; set; }
    }
}
