using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class EhsRegulatoryTrends
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string HeadingName { get; set; }
        public DateTime? TopicReportDate { get; set; }
        public DateTime TopicCreateDate { get; set; }
        public int Idtopic { get; set; }
        public string Status { get; set; }
        public string TopicIssueCode { get; set; }
        public string Title { get; set; }
    }
}
