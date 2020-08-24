using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClientContracts
    {
        public int Idclient { get; set; }
        public string ClientName { get; set; }
        public string ClientLongName { get; set; }
        public string ServiceCode { get; set; }
        public string LanguageCode { get; set; }
        public DateTime? StartOfDelivery { get; set; }
        public DateTime? EndOfDelivery { get; set; }
        public string ClientStatus { get; set; }
        public string ClientAccount { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string Name { get; set; }
        public bool WebDelivery { get; set; }
    }
}
