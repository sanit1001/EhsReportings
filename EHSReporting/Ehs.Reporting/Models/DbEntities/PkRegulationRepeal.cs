using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkRegulationRepeal
    {
        public int RegId { get; set; }
        public int RegIdrepealed { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
