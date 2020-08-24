using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkTopicHeading
    {
        public int Idtopic { get; set; }
        public string HeadingCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
