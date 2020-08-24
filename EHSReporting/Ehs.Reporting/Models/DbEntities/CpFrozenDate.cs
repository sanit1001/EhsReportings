using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CpFrozenDate
    {
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string LanguageCode { get; set; }
        public string Note { get; set; }
        public DateTime FreezeDate { get; set; }
        public int IntroId { get; set; }
    }
}
