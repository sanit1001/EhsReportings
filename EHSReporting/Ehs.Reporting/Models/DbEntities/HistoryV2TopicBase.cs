using System;
using System.Collections.Generic;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryV2TopicBase
    {
        public HistoryV2TopicBase()
        {
            TrackingV2TopicBase = new HashSet<TrackingV2TopicBase>();
        }

        public string CountryCode { get; set; }
        public int? Idstatus { get; set; }
        public int? RegCitationlinked { get; set; }
        public DateTime? AdoptionDate { get; set; }
        public int? Idcontact { get; set; }
        public DateTime? ReportDate { get; set; }
        public string InternalCode { get; set; }
        public string Idproduct { get; set; }
        public bool Archived { get; set; }
        public string ArchivedBy { get; set; }
        public DateTime? DateArchived { get; set; }
        public string ContactType { get; set; }
        public string BaseLanguageCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public int Idtopic { get; set; }

        public virtual ICollection<TrackingV2TopicBase> TrackingV2TopicBase { get; set; }
    }
}
