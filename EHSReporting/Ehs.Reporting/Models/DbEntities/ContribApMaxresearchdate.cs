using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ContribApMaxresearchdate
    {
        public DateTime? MaxResearchDate { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public bool Archived { get; set; }
    }
}
