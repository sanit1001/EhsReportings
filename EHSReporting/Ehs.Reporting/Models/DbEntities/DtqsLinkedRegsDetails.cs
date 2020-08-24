using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class DtqsLinkedRegsDetails
    {
        public string Country { get; set; }
        public string RegionName { get; set; }
        public string DecTreeCode { get; set; }
        public string LanguageCode { get; set; }
        public string RowStatus { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string DecTreeText { get; set; }
        public string DecTreeGuideNote { get; set; }
        public string RegTitle { get; set; }
    }
}
