using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClMrNewsCc
    {
        public DateTime? ReportDate { get; set; }
        public string CountryCode { get; set; }
        public string Remarks { get; set; }
        public DateTime? ImplementationDate { get; set; }
    }
}
