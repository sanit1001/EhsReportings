using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkRegulationHeading
    {
        public int RegId { get; set; }
        public string HeadingCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
        public string AutoId { get; set; }
    }
}
