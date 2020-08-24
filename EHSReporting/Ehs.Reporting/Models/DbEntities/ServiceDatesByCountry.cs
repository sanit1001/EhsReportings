using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ServiceDatesByCountry
    {
        public string CountryCode { get; set; }
        public DateTime DateCp { get; set; }
        public DateTime DateIs { get; set; }
        public DateTime DateRr { get; set; }
        public DateTime DateLg { get; set; }
        public DateTime DateAp { get; set; }
        public DateTime DateSc { get; set; }
        public DateTime LatestReportDate { get; set; }
        public DateTime EarliestAdoptionDate { get; set; }
    }
}
