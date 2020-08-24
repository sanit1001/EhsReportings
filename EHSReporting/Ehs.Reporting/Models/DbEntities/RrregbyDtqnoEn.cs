using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class RrregbyDtqnoEn
    {
        public string DecTreeCode { get; set; }
        public int RegId { get; set; }
        public string RegTitle { get; set; }
        public string RegHyperlink { get; set; }
        public string ConsolidatedHyperlink { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public bool Effective { get; set; }
        public bool Archive { get; set; }
        public DateTime ValidityDate { get; set; }
    }
}
