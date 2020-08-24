namespace Ehs.Reporting.MR.Models
{
    public partial class ClAllClientRegionLangOutput
    {
        public int Idclient { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string LanguageCode { get; set; }
        public int FormatId { get; set; }
        public string OutPutLink { get; set; }
        public string Note { get; set; }
        public string OutPutFileName { get; set; }
    }
}
