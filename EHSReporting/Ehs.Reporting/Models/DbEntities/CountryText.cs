using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CountryText
    {
        public string CountryCode { get; set; }
        public string LanguageCode { get; set; }
        public string CountryName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
