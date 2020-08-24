using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class QryListofLegislationcountwithnoamend
    {
        public string CountryName { get; set; }
        public int? Counter { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public DateTime? MaxOfValidityDate { get; set; }
        public string LanguageCode { get; set; }
        public DateTime? MaxOfnewResearchDate { get; set; }
    }
}
