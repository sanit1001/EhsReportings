using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryCoIndustryRegulation
    {
        public int IndCode { get; set; }
        public int RegId { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
