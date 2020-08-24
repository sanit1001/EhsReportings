using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CpFrozenDateNew
    {
        public DateTime? FreezeDate { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string LanguageCode { get; set; }
        public string Note { get; set; }
    }
}
