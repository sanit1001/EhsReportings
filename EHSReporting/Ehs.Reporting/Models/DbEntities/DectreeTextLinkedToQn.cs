using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class DectreeTextLinkedToQn
    {
        public string DecTreeCode { get; set; }
        public string DecTreeQn { get; set; }
        public string QnCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string Description { get; set; }
        public string ChangeNotes { get; set; }
        public DateTime StartDate { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
    }
}
