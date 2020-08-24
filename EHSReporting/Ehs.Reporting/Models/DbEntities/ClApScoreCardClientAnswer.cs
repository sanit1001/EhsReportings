using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClApScoreCardClientAnswer
    {
        public int ScoreCardId { get; set; }
        public string QnCode { get; set; }
        public DateTime SubmitDate { get; set; }
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string Answer { get; set; }
        public string Comment { get; set; }
        public string FindingTitle { get; set; }
        public string RiskExposure { get; set; }
        public string Effect { get; set; }
        public string RiskFactor { get; set; }
        public string ActionItem { get; set; }
        public string SystemFactor { get; set; }
        public string ResponseCost { get; set; }
        public string Recommendation { get; set; }
        public string RequiredCloseOutDate { get; set; }
        public string PercentageCompleted { get; set; }
        public string Likelihood { get; set; }
        public string Consequance { get; set; }
        public string ResposiblePerson { get; set; }
    }
}
