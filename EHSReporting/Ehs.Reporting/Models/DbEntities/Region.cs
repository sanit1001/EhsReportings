namespace Ehs.Reporting.MR.Models
{
    public partial class Region
    {
        public int? Idregion { get; set; }
        public string Region1 { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string IsoCode { get; set; }
        public bool? VisibleInListOfRegs { get; set; }
    }
}
