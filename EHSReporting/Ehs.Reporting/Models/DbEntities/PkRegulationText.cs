using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkRegulationText
    {
        public int RegId { get; set; }
        public string LanguageCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
        public string AutoId { get; set; }
    }
}
