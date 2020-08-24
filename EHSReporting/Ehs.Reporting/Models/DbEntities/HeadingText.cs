using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HeadingText
    {
        public string HeadingCode { get; set; }
        public string LanguageCode { get; set; }
        public string HeadingName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string GeneralDescription { get; set; }
    }
}
