using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class QryWithoutValidityDate
    {
        public string CountryName { get; set; }
        public DateTime ValidityDate { get; set; }
        public string RegionCode { get; set; }
        public DateTime? ValidityDate1 { get; set; }
    }
}
