using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryRegulationRegulation
    {
        public int RegId { get; set; }
        public int ChildRegId { get; set; }
        public string SortCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
