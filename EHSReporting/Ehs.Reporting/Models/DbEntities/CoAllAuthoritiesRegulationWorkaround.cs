using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoAllAuthoritiesRegulationWorkaround
    {
        public int AuthorityId { get; set; }
        public int RegId { get; set; }
        public int AuthorityTypeId { get; set; }
        public DateTime StartDate { get; set; }
    }
}
