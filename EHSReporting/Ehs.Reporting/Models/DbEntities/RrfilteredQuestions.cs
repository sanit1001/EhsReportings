using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class RrfilteredQuestions
    {
        public string HeadingCode { get; set; }
        public string HeadingName { get; set; }
        public int RegId { get; set; }
        public int RegulationType { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public DateTime ValidityDate { get; set; }
        public string LanguageCodeHeadings { get; set; }
        public byte RegMajorVersion { get; set; }
    }
}
