using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MrOutdatedProposals
    {
        public int Idtopic { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public DateTime? ReporteDate { get; set; }
        public string LanguageCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string RowStatus { get; set; }
        public DateTime NewResearchDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime StartDate { get; set; }
    }
}
