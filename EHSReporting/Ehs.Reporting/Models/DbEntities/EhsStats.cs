namespace Ehs.Reporting.MR.Models
{
    public partial class EhsStats
    {
        public int Idtopic { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string HeadingName { get; set; }
        public int Totals { get; set; }
        public int? YearCreated { get; set; }
        public int? MonthCreated { get; set; }
        public int? YearReportDate { get; set; }
        public int? MonthReportDate { get; set; }
    }
}
