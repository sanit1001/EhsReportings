using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClMrNewsContracted
    {
        public string CountryCode { get; set; }
        public DateTime? MaxReportDate { get; set; }
        public DateTime? MinReportDate { get; set; }
        public string CountryName { get; set; }
    }
}
