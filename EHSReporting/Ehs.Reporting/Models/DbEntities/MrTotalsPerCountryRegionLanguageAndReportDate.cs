namespace Ehs.Reporting.MR.Models
{
    public partial class MrTotalsPerCountryRegionLanguageAndReportDate
    {
        public string LanguageCode { get; set; }
        public string ReportDate { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int? TotalMrs { get; set; }
    }
}
