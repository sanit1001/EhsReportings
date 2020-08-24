namespace Ehs.Reporting.MR.Models
{
    public partial class RegulationNotLinkedToQn
    {
        public int RegId { get; set; }
        public string Country { get; set; }
        public bool Active { get; set; }
        public string Region { get; set; }
        public string LanguageCode { get; set; }
        public string RegTitle { get; set; }
    }
}
