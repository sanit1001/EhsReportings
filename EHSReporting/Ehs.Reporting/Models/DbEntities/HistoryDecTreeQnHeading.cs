using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryDecTreeQnHeading
    {
        public string HeadingCode { get; set; }
        public string DecTreeCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
