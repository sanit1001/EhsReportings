using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoApNumberofQnNullOfficesperCountryView
    {
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public int? Total { get; set; }
        public DateTime? CutOffDate { get; set; }
    }
}
