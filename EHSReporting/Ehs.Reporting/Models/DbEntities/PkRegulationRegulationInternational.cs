using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkRegulationRegulationInternational
    {
        public int RegId { get; set; }
        public int ChildRegId { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
