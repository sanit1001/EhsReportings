using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MrstatsForBdandMrteam
    {
        public int Idtopic { get; set; }
        public string Status { get; set; }
        public string LanguageCode { get; set; }
        public DateTime? ReportDate { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int Number { get; set; }
        public string Topic { get; set; }
    }
}
