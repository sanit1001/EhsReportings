using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkRegulationRegulation
    {
        public int RegId { get; set; }
        public int ChildRegId { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
