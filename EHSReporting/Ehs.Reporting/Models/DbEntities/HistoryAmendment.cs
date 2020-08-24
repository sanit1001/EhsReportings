using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryAmendment
    {
        public string AmendmentCode { get; set; }
        public int? RegId { get; set; }
        public string SortCode { get; set; }
        public DateTime? AmendmentDate { get; set; }
        public bool Archive { get; set; }
        public string BaseLanguageCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
