using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryCitationText
    {
        public int Idcitation { get; set; }
        public string LanguageCode { get; set; }
        public string Citation { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public string AutoId { get; set; }
    }
}
