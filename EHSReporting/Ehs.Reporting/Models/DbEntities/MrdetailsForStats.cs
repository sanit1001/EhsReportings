using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MrdetailsForStats
    {
        public int Idtopic { get; set; }
        public bool Archived { get; set; }
        public string Summary { get; set; }
        public string Topic { get; set; }
        public DateTime? ReportDate { get; set; }
        public string LanguageCode { get; set; }
    }
}
