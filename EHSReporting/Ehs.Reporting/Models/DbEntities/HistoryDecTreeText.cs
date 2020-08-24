using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryDecTreeText
    {
        public string DecTreeCode { get; set; }
        public string LanguageCode { get; set; }
        public string DecTreeQn { get; set; }
        public string DecTreeGuideNote { get; set; }
        public string DecTreeYesConfirm { get; set; }
        public string DecTreeNoConfirm { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? ValidityDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public string AutoId { get; set; }
    }
}
