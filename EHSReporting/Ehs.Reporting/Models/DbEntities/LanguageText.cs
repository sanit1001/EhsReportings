using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class LanguageText
    {
        public string LanguageCode { get; set; }
        public string InLanguageCode { get; set; }
        public DateTime? LanguageDate { get; set; }
        public string LanguageName { get; set; }
    }
}
