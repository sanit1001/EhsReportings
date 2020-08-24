using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryQnItems
    {
        public string QnCode { get; set; }
        public string LanguageCode { get; set; }
        public int SortCode { get; set; }
        public int ItemId { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public int AutoId { get; set; }
    }
}
