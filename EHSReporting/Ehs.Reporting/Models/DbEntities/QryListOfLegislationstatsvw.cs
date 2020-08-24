using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class QryListOfLegislationstatsvw
    {
        public string CountryName { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public DateTime? AmendmentDate { get; set; }
        public string RegionCode { get; set; }
        public string CountryCode { get; set; }
        public string LanguageCode { get; set; }
        public DateTime NewResearchDate { get; set; }
    }
}
