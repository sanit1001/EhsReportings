using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class GeCutoffDates2005
    {
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public DateTime? DateCutoff { get; set; }
        public bool? HasQnCode { get; set; }
    }
}
