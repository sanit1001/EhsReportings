using System;
using System.Collections.Generic;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryV2ImplementationText
    {
        public HistoryV2ImplementationText()
        {
            TrackingV2ImplementationText = new HashSet<TrackingV2ImplementationText>();
        }

        public int Idimplementation { get; set; }
        public string LanguageCode { get; set; }
        public string Remarks { get; set; }
        public Guid RowId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? DateLastModified { get; set; }
        public string Md5 { get; set; }

        public virtual ICollection<TrackingV2ImplementationText> TrackingV2ImplementationText { get; set; }
    }
}
