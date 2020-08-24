using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryRequiredAnswer
    {
        public string DecTreeCode { get; set; }
        public string QnCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
