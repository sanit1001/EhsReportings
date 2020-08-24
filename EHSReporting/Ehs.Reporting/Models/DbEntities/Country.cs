namespace Ehs.Reporting.MR.Models
{
    public partial class Country
    {
        public string CountryCode { get; set; }
        public bool Eu { get; set; }
        public string Country1 { get; set; }
        public string RegionType { get; set; }
        public int WorldAreaId { get; set; }
        public int? Intl { get; set; }
    }
}
