using System;
using System.Collections.Generic;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryV2MrBusinessImpactText
    {
        public HistoryV2MrBusinessImpactText()
        {
            TrackingV2MrBusinessImpactText = new HashSet<TrackingV2MrBusinessImpactText>();
        }

        public string LanguageCode { get; set; }
        public string AnalysisBusinessImpact { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateLastModified { get; set; }
        public string ModifiedBy { get; set; }
        public byte? Status { get; set; }
        public Guid RowId { get; set; }
        public int Idclient { get; set; }
        public int Idtopic { get; set; }
        public string Md5 { get; set; }

        public virtual ICollection<TrackingV2MrBusinessImpactText> TrackingV2MrBusinessImpactText { get; set; }
    }
}
