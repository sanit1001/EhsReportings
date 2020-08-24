using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryAmendmentText
    {
        public string AmendmentCode { get; set; }
        public string LanguageCode { get; set; }
        public string AmendmentTitle { get; set; }
        public string AmendmentRef { get; set; }
        public string Hyperlink { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? ValidityDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
