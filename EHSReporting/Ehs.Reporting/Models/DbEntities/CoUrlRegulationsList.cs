using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoUrlRegulationsList
    {
        public int RegId { get; set; }
        public string LanguageCode { get; set; }
        public string RegComment { get; set; }
        public string RegSummary { get; set; }
        public string RegHyperlink { get; set; }
        public string ConsolidatedHyperlink { get; set; }
        public string MainRequirements { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool Archive { get; set; }
        public DateTime? ParseDate { get; set; }
        public int? D { get; set; }
    }
}
