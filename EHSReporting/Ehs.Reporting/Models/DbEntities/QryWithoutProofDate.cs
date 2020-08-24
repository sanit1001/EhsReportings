using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class QryWithoutProofDate
    {
        public string CountryName { get; set; }
        public string RegionCode { get; set; }
        public DateTime? ProofedDate { get; set; }
    }
}
