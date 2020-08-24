using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class UpdatesContracts
    {
        public int Idclient { get; set; }
        public string ServiceCode { get; set; }
        public string HeadingSetName { get; set; }
        public DateTime StartOfDelivery { get; set; }
        public DateTime EndOfDelivery { get; set; }
        public string ClientName { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string RegionCode { get; set; }
        public string Region { get; set; }
        public string LanguageCode { get; set; }
    }
}
