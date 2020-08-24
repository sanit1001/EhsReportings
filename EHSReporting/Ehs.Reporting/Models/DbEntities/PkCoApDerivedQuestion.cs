using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkCoApDerivedQuestion
    {
        public string QnCodeMaster { get; set; }
        public string QnCodeDerived { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
