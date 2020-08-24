using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryRegulationRepeal
    {
        public int RegId { get; set; }
        public int RegIdrepealed { get; set; }
        public DateTime RepealDate { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
