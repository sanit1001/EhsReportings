using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MissingIssuingAuthoritiesForIntelX
    {
        public int RegId { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string RegTitle { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
