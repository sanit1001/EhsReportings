using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TopicPerCountryRecurrentStatsForTranslation
    {
        public int? TotalMrs { get; set; }
        public string RegionName { get; set; }
        public string Country { get; set; }
        public string LanguageCode { get; set; }
        public DateTime? ReportDate { get; set; }
    }
}
