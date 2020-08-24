using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class QryWithoutValidityDateProduction
    {
        public string CountryName { get; set; }
        public string RegionCode { get; set; }
        public string HeadingCode { get; set; }
        public DateTime NewResearchDate { get; set; }
    }
}
