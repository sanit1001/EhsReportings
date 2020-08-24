using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TranslatedV2TopicText
    {
        public int Idtopic { get; set; }
        public string LanguageCode { get; set; }
        public string Topic { get; set; }
        public string Rapid { get; set; }
        public string Summary { get; set; }
        public string IssuingAuthority { get; set; }
        public string EnforcingAuthority { get; set; }
        public string RegulatoryCitation { get; set; }
        public string LegislationRepealed { get; set; }
        public string AffectedOperations { get; set; }
        public string RegulatoryText { get; set; }
        public DateTime? DateLastModified { get; set; }
        public DateTime? StartDateBase { get; set; }
        public int? UpdateTypeId { get; set; }
        public string RowStatus { get; set; }
        public DateTime? NewResearchDate { get; set; }
    }
}
