using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class QryListofLegislationdate
    {
        public string CountryName { get; set; }
        public DateTime? MaxOfReferenceDate { get; set; }
        public DateTime? MaxOfAmendmentDate { get; set; }
        public string RegionCode { get; set; }
        public DateTime? MaxOfnewResearchDate { get; set; }
    }
}
