using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class QryLatestValidityDateVw
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public DateTime? MaxOfValidityDate { get; set; }
        public string RegionCode { get; set; }
        public DateTime? MaxOfProofedDate { get; set; }
    }
}
