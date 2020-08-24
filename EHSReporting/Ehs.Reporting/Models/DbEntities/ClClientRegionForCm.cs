namespace Ehs.Reporting.MR.Models
{
    public partial class ClClientRegionForCm
    {
        public int Idclient { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string SetCode { get; set; }
        public bool IncludeFederal { get; set; }
    }
}
