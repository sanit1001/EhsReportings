namespace Ehs.Reporting.MR.Models
{
    public partial class MrperCountryRegionLanguageStats
    {
        public string ReportDate { get; set; }
        public int Idtopic { get; set; }
        public string Status { get; set; }
        public string LanguageCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Topic { get; set; }
        public int? RapidLength { get; set; }
        public long? SummaryLentgh { get; set; }
    }
}
