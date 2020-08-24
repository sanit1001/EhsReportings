using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class AllCpIntro
    {
        public int IntroId { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageName { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string HeadingCode { get; set; }
        public string HeadingName { get; set; }
        public string ValidityDate { get; set; }
        public string CreateDate { get; set; }
        public string LastModifiedDate { get; set; }
        public string Intro { get; set; }
        public string Notes { get; set; }
        public DateTime NewResearchDate { get; set; }
    }
}
