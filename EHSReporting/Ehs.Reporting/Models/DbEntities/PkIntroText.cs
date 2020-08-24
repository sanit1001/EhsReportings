using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkIntroText
    {
        public int IntroId { get; set; }
        public string LanguageCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
