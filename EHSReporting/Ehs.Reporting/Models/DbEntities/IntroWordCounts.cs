namespace Ehs.Reporting.MR.Models
{
    public partial class IntroWordCounts
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string Heading { get; set; }
        public string LanguageCode { get; set; }
        public short? NumberOfIntroWords { get; set; }
    }
}
