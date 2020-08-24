using System;
using System.Collections.Generic;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryV2ImplementationBase
    {
        public HistoryV2ImplementationBase()
        {
            TrackingV2ImplementationBase = new HashSet<TrackingV2ImplementationBase>();
        }

        public int? Idtopic { get; set; }
        public DateTime? ImplementationDate { get; set; }
        public float Repetition { get; set; }
        public int? RegId { get; set; }
        public string BaseLanguageCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public int Idimplementation { get; set; }

        public virtual ICollection<TrackingV2ImplementationBase> TrackingV2ImplementationBase { get; set; }
    }
}
