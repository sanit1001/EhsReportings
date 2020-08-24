using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CountryInformation
    {
        public string CountryCode { get; set; }
        public DateTime? LatestReportDate { get; set; }
        public DateTime? EarliestAdoptionDate { get; set; }
    }
}
