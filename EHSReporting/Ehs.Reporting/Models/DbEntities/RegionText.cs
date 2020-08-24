using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class RegionText
    {
        public string RegionCode { get; set; }
        public string CountryCode { get; set; }
        public string LanguageCode { get; set; }
        public string RegionName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
