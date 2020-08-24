using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ContractedCountriesLanguage
    {
        public int Idclient { get; set; }
        public string CountryCode { get; set; }
        public string ServiceCode { get; set; }
        public string LanguageCode { get; set; }
        public string SetCode { get; set; }
        public bool WebDelivery { get; set; }
        public bool FtpFile { get; set; }
        public bool TakeLatestCp { get; set; }
        public DateTime? FroozenCpdate { get; set; }
    }
}
