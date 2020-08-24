namespace Ehs.Reporting.MR.Models
{
    public partial class RegulationsForIntel
    {
        public int Idclient { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public int? ContractedRegulations { get; set; }
    }
}
