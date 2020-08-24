using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ProductAssessmentQuestionStatus
    {
        public string CountryName { get; set; }
        public string RegionName { get; set; }
        public string QnCode { get; set; }
        public int? Idcitation { get; set; }
        public int? RegId { get; set; }
        public string HeadingCode { get; set; }
        public DateTime QnNewResearchDate { get; set; }
        public string QnRowStatus { get; set; }
        public int QnUpdateTypeId { get; set; }
        public string QnUpdateTypeDescription { get; set; }
        public string CitationBaseRowStatus { get; set; }
        public DateTime? CitationBasenewResearchDate { get; set; }
        public int? CitationBaseUpdateTypeId { get; set; }
        public string CitationUpdTypeDescription { get; set; }
        public DateTime? RegulationnewResearchDate { get; set; }
        public string RegulationrowStatus { get; set; }
        public int? RegulationUpdateTypeId { get; set; }
        public string RegUpdateTypeDescription { get; set; }
        public bool QnArchived { get; set; }
        public bool? RegArchived { get; set; }
    }
}
