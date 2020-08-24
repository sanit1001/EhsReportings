using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoApItemsText
    {
        public int ItemId { get; set; }
        public string LanguageCode { get; set; }
        public string Item { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public byte? Status { get; set; }
    }
}
