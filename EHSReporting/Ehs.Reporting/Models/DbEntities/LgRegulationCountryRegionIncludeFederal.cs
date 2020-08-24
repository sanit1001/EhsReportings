namespace Ehs.Reporting.MR.Models
{
    public partial class LgRegulationCountryRegionIncludeFederal
    {
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public int RegId { get; set; }
        public string RegionCodeOriginal { get; set; }
        public bool IncludeFederal { get; set; }
        public int Idclient { get; set; }
        public string ServiceCode { get; set; }
        public string SetCode { get; set; }
    }
}
