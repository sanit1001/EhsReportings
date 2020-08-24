using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class RrregbyDtq
    {
        public string DecTreeCode { get; set; }
        public int RegId { get; set; }
        public string RegTitle { get; set; }
        public string RegHyperlink { get; set; }
        public string ConsolidatedHyperlink { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public DateTime ValidityDate { get; set; }
        public bool Archive { get; set; }
        public string LanguageCode { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Effective { get; set; }
    }
}
