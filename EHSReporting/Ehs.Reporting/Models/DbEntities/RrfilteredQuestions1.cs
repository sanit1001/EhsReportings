using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class RrfilteredQuestions1
    {
        public string HeadingCode1 { get; set; }
        public int RegId { get; set; }
        public int RegulationType { get; set; }
        public string CountryCode { get; set; }
        public string LanguageCode { get; set; }
        public DateTime ValidityDate { get; set; }
        public string RegionCode { get; set; }
        public byte RegMajorVersion { get; set; }
    }
}
