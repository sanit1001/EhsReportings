using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryQnImage
    {
        public string QnCode { get; set; }
        public string ImageLink { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
