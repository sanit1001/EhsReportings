using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryRegulationDecTreeQn
    {
        public string DecTreeCode { get; set; }
        public int RegId { get; set; }
        public bool? MainDtq { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
