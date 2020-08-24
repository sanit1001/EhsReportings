using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClApScoreCard
    {
        public int ScoreCardId { get; set; }
        public DateTime CutOffDate { get; set; }
        public string CountryCode { get; set; }
        public DateTime ResearchDate { get; set; }
        public string DualLanguageCode { get; set; }
        public string Description { get; set; }
        public bool IsOffice { get; set; }
        public bool IsWareHouse { get; set; }
        public int? IndustrySector { get; set; }
        public string HeadingSet { get; set; }
        public string RegionCode { get; set; }
    }
}
