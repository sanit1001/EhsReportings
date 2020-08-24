using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClApItemsPublished
    {
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string QnCode { get; set; }
        public DateTime NewResearchDate { get; set; }
        public int ItemId { get; set; }
        public string LanguageCode { get; set; }
        public string Item { get; set; }
        public string Type { get; set; }
    }
}
