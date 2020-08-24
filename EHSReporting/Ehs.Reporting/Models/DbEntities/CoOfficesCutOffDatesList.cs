using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoOfficesCutOffDatesList
    {
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public DateTime? CutOffDate { get; set; }
        public bool? IsFirstTime { get; set; }
    }
}
