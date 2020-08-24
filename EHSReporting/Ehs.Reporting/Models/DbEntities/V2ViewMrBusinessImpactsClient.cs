using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class V2ViewMrBusinessImpactsClient
    {
        public int Idclient { get; set; }
        public string LanguageCode { get; set; }
        public int Idtopic { get; set; }
        public DateTime? ClientReportDate { get; set; }
        public string AnalysisBusinessImpact { get; set; }
        public string Importance { get; set; }
    }
}
