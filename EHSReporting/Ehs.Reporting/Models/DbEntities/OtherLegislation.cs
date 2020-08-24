namespace Ehs.Reporting.MR.Models
{
    public partial class OtherLegislation
    {
        public int RegId { get; set; }
        public int RegulationType { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string LanguageCode { get; set; }
        public string RegTitle { get; set; }
        public bool Archive { get; set; }
    }
}
