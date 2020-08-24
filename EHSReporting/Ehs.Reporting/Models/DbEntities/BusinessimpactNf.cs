using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class BusinessimpactNf
    {
        public int Idtopic { get; set; }
        public DateTime? ClientReportDate { get; set; }
        public int Idclient { get; set; }
        public string Importance { get; set; }
        public string AnalysisBusinessImpact { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateLastModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
