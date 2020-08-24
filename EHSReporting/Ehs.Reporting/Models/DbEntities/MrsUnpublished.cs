using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MrsUnpublished
    {
        public int Idtopic { get; set; }
        public string RowStatus { get; set; }
        public string Status { get; set; }
        public string CountryName { get; set; }
        public string RegionName { get; set; }
        public string Area { get; set; }
        public string Title { get; set; }
        public DateTime? ReportDate { get; set; }
        public DateTime TopicBasenewResearchDate { get; set; }
    }
}
