using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkCitationQn
    {
        public int Idcitation { get; set; }
        public string QnCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
        public string AutoId { get; set; }
    }
}
