using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class V2LookupServicesByClient
    {
        public string ClientName { get; set; }
        public int Idclient { get; set; }
        public string ClientLongName { get; set; }
        public string CountryName { get; set; }
        public string LanguageName { get; set; }
        public string ServiceCode { get; set; }
        public string RegionCode { get; set; }
        public string SetCode { get; set; }
        public string LanguageCode { get; set; }
        public DateTime? StartOfDelivery { get; set; }
        public DateTime? EndOfDelivery { get; set; }
    }
}
