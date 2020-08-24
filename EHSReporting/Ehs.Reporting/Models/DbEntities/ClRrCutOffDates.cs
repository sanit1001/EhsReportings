using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClRrCutOffDates
    {
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public DateTime? CutOffDate { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
    }
}
