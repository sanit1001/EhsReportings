using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryDecTreeCodeDecTreeCode
    {
        public string DecTreeCodeChild { get; set; }
        public string DecTreeCodeParent { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
