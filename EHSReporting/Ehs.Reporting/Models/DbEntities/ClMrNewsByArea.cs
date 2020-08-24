using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClMrNewsByArea
    {
        public int Idtopic { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Topic { get; set; }
        public string Rapid { get; set; }
        public DateTime? ReportDate { get; set; }
        public string Area { get; set; }
        public int Idarea { get; set; }
    }
}
