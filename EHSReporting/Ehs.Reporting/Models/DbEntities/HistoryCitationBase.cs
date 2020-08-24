using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryCitationBase
    {
        public int RegId { get; set; }
        public int Idcitation { get; set; }
        public string BaseLanguageCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public string SortOrder { get; set; }
        public string AutoId { get; set; }
    }
}
