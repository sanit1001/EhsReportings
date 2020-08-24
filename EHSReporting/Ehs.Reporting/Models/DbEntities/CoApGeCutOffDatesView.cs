using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoApGeCutOffDatesView
    {
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public DateTime? DateCutoff { get; set; }
    }
}
