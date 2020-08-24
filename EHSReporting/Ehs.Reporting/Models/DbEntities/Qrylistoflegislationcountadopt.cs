using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class Qrylistoflegislationcountadopt
    {
        public DateTime? MaxOfAdoptionDate { get; set; }
        public string CountryCode { get; set; }
        public int? Counter { get; set; }
        public string RegionCode { get; set; }
        public DateTime? MaxOfValidityDate { get; set; }
        public string CountryName { get; set; }
        public string LanguageCode { get; set; }
    }
}
