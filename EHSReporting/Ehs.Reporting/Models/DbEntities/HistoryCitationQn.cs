using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryCitationQn
    {
        public int Idcitation { get; set; }
        public string QnCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public string AutoId { get; set; }
    }
}
