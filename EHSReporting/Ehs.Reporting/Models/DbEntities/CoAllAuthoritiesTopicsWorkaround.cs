using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoAllAuthoritiesTopicsWorkaround
    {
        public DateTime StartDate { get; set; }
        public int AuthorityId { get; set; }
        public int Idtopic { get; set; }
        public int AuthorityTypeId { get; set; }
    }
}
