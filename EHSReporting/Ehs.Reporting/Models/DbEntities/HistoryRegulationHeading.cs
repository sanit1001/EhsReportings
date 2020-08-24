using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryRegulationHeading
    {
        public int RegId { get; set; }
        public string HeadingCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public string AutoId { get; set; }
    }
}
