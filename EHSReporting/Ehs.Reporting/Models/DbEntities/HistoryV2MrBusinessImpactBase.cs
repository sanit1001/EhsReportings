using System;
using System.Collections.Generic;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryV2MrBusinessImpactBase
    {
        public HistoryV2MrBusinessImpactBase()
        {
            TrackingV2MrBusinessImpactBase = new HashSet<TrackingV2MrBusinessImpactBase>();
        }

        public int Idtopic { get; set; }
        public DateTime? ClientReportDate { get; set; }
        public int Idclient { get; set; }
        public string Importance { get; set; }
        public string BaseLanguageCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }

        public virtual ICollection<TrackingV2MrBusinessImpactBase> TrackingV2MrBusinessImpactBase { get; set; }
    }
}
