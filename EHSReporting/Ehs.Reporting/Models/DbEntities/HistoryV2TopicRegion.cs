using System;
using System.Collections.Generic;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryV2TopicRegion
    {
        public HistoryV2TopicRegion()
        {
            TrackingV2TopicRegion = new HashSet<TrackingV2TopicRegion>();
        }

        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public int Idtopic { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }

        public virtual ICollection<TrackingV2TopicRegion> TrackingV2TopicRegion { get; set; }
    }
}
