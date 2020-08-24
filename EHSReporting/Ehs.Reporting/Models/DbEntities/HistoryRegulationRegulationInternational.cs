using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryRegulationRegulationInternational
    {
        public int RegId { get; set; }
        public int ChildRegId { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
