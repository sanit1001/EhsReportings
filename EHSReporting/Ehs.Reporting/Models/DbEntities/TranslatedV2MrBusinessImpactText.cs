using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TranslatedV2MrBusinessImpactText
    {
        public int Idclient { get; set; }
        public int Idtopic { get; set; }
        public string LanguageCode { get; set; }
        public string AnalysisBusinessImpact { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public byte? Status { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public DateTime? DateLastModified { get; set; }
        public DateTime? StartDateBase { get; set; }
        public int? UpdateTypeId { get; set; }
        public string RowStatus { get; set; }
        public DateTime? NewResearchDate { get; set; }
    }
}
