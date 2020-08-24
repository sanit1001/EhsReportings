using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class QryLatestValidityDate
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public DateTime? MaxOfValidityDate { get; set; }
        public string RegionCode { get; set; }
        public DateTime? MaxOfProofedDate { get; set; }
        public string LanguageCode { get; set; }
    }
}
