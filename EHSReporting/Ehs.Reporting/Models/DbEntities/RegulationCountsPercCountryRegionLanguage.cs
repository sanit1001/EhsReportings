namespace Ehs.Reporting.MR.Models
{
    public partial class RegulationCountsPercCountryRegionLanguage
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string LanguageCode { get; set; }
        public int? NumberOfRegs { get; set; }
    }
}
