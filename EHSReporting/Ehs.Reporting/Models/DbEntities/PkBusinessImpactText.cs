using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkBusinessImpactText
    {
        public int IntroId { get; set; }
        public int Idclient { get; set; }
        public string LanguageCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
