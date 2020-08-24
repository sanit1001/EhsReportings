namespace Ehs.Reporting.MR.Models
{
    public partial class ClAllClientRegion
    {
        public int Idclient { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string SetCode { get; set; }
        public bool? IncludeFederal { get; set; }
        public bool? IncludeGenericIndustry { get; set; }
        public bool? IsForOffices { get; set; }
        public bool? IsForWareHouses { get; set; }
        public int? IndustrySector { get; set; }
        public string MasterCountryCode { get; set; }
        public string MasterRegionCode { get; set; }
        public bool HasMappedHeadings { get; set; }
        public bool IsRto { get; set; }
        public bool ExcludeRequirements { get; set; }
    }
}
