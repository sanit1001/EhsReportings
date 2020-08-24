using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkCoAllServiceVersion
    {
        public string ServiceCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string LanguageCode { get; set; }
        public string SetCode { get; set; }
        public int IndCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
        public string ProductTypeCode { get; set; }
    }
}
