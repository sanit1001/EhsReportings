using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class GeneralText
    {
        public string TextCode { get; set; }
        public string LanguageCode { get; set; }
        public string TextString { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
