using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class QryListofLegislationstatswithnoamend
    {
        public string CountryName { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public string CountryCode { get; set; }
        public DateTime ValidityDate { get; set; }
        public string LanguageCode { get; set; }
        public string RegionCode { get; set; }
        public bool Archive { get; set; }
        public DateTime NewResearchDate { get; set; }
    }
}
