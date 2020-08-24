using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkLgRegulationCountryRegion
    {
        public int RegId { get; set; }
        public string RegionCode { get; set; }
        public string CountryCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
        public string AutoId { get; set; }
    }
}
