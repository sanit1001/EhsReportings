using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TblDeliverableConsultants
    {
        public int DcDlId { get; set; }
        public int? DcConsultantId { get; set; }
        public int? DcEstimatedTime { get; set; }
        public int? DcSpendTime { get; set; }
        public byte DcPriority { get; set; }
        public string DcDescription { get; set; }
        public DateTime? DcDate { get; set; }
        public int DcId { get; set; }
        public DateTime? DcEndDate { get; set; }
        public int? DcCompleted { get; set; }
        public int? DcmrSortOrder { get; set; }
        public string DcComments { get; set; }
        public DateTime? Dcdaterelated { get; set; }
        public int? Dcstatus { get; set; }
        public bool ValidateByConsultant { get; set; }
        public DateTime? ValidationDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ValidatedBy { get; set; }
        public DateTime? FirstOfTheMonth { get; set; }
    }
}
