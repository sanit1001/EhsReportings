namespace Ehs.Reporting.MR.Models
{
    public partial class ClPaProductTypeClientRegion
    {
        public int Idclient { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string ProductTypeCode { get; set; }
        public bool Archived { get; set; }
    }
}
