using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class AsqLinkedToApquestionsUs
    {
        public string DtqRegionCode { get; set; }
        public string RegionName { get; set; }
        public string Asq { get; set; }
        public string QnCode { get; set; }
        public int QnUpdateTypeId { get; set; }
        public string QnRegionCode { get; set; }
        public string DecTreeQn { get; set; }
        public string DecTreeGuideNote { get; set; }
        public string DecTreeYesConfirm { get; set; }
        public string DecTreeNoConfirm { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? ValidityDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DtqNewResearchDate { get; set; }
        public string DtqRowStatus { get; set; }
        public string Qn { get; set; }
        public string QnGuideNote { get; set; }
        public DateTime QnTextNewResearchDate { get; set; }
        public string QnTextRowStatus { get; set; }
    }
}
