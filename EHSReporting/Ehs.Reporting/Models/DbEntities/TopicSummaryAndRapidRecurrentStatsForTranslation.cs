using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TopicSummaryAndRapidRecurrentStatsForTranslation
    {
        public short? AnalysisNbrOfWords { get; set; }
        public string LanguageCode { get; set; }
        public string Country { get; set; }
        public short? AbstractNbrOfWords { get; set; }
        public string Region { get; set; }
        public DateTime? ReportDate { get; set; }
    }
}
