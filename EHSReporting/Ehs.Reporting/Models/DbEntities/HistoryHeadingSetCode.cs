using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryHeadingSetCode
    {
        public string SetCode { get; set; }
        public string HeadingCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
