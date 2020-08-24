using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryCoApDerivedQuestion
    {
        public string QnCodeMaster { get; set; }
        public string QnCodeDerived { get; set; }
        public int? TypeId { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Notes { get; set; }
        public bool Archived { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
