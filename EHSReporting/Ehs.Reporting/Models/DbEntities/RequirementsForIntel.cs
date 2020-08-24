namespace Ehs.Reporting.MR.Models
{
    public partial class RequirementsForIntel
    {
        public int Idclient { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public int? ContractedRequirements { get; set; }
    }
}
