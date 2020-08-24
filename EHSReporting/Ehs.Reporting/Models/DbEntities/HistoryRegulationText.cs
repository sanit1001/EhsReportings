using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryRegulationText
    {
        public int RegId { get; set; }
        public string LanguageCode { get; set; }
        public string RegTitle { get; set; }
        public string RegSummary { get; set; }
        public string RegHyperlink { get; set; }
        public string ConsolidatedHyperlink { get; set; }
        public string MainRequirements { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime ValidityDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Guid RowId { get; set; }
        public string RepealNote { get; set; }
        public string Md5 { get; set; }
        public string AutoId { get; set; }
    }
}
