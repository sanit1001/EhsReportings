namespace Ehs.Reporting.MR.Models
{
    public partial class V2UrlsLgUsed
    {
        public string Urlcode { get; set; }
        public int Pk { get; set; }
        public int RegId { get; set; }
        public string LanguageCode { get; set; }
        public string RegTitle { get; set; }
        public string RegSummary { get; set; }
        public string RegHyperlink { get; set; }
        public string ConsolidatedHyperlink { get; set; }
        public string MainRequirements { get; set; }
    }
}
