using System;
using System.Collections.Generic;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryTopicHeading
    {
        public HistoryTopicHeading()
        {
            TrackingTopicHeading = new HashSet<TrackingTopicHeading>();
        }

        public int Idtopic { get; set; }
        public string HeadingCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }

        public virtual ICollection<TrackingTopicHeading> TrackingTopicHeading { get; set; }
    }
}
