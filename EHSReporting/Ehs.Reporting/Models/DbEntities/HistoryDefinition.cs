using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryDefinition
    {
        public int DefNumber { get; set; }
        public int RegId { get; set; }
        public string BaseLanguageCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
