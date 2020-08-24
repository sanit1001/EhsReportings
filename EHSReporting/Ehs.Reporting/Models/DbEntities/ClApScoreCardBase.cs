using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClApScoreCardBase
    {
        public int ScoreCardId { get; set; }
        public string QnCode { get; set; }
        public string CountryCode { get; set; }
        public string OriginalQnRegionCode { get; set; }
        public string OriginalQnHeadingCode { get; set; }
        public string Changed { get; set; }
        public DateTime? LastReviewedDate { get; set; }
        public string ReviewedBy { get; set; }
        public int? OriginalSortCode { get; set; }
        public bool? OriginalyArchived { get; set; }
        public int OriginalIndustrySector { get; set; }
        public string LinkedRegions { get; set; }
        public string LinkedQnCodes { get; set; }
    }
}
