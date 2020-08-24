using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MrB
    {
        public int Idclient { get; set; }
        public int IdservicesProxy { get; set; }
        public int IdcontentProxy { get; set; }
        public string CountryCode { get; set; }
        public string LanguageCode { get; set; }
        public int Idtopic { get; set; }
        public DateTime? EarliestReportDate { get; set; }
    }
}
