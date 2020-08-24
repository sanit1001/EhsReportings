using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ContribApMaxchangeddate
    {
        public DateTime? MaxResearchDate { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public bool Archived { get; set; }
    }
}
