using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkV2MrBusinessImpactText
    {
        public int Idclient { get; set; }
        public int Idtopic { get; set; }
        public string LanguageCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
