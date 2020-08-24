namespace Ehs.Reporting.MR.Models
{
    public partial class V2UrlsMrUsed
    {
        public string Urlcode { get; set; }
        public int Pk { get; set; }
        public int Idtopic { get; set; }
        public string LanguageCode { get; set; }
        public string Topic { get; set; }
        public string Rapid { get; set; }
        public string Summary { get; set; }
        public string ArchiveReference { get; set; }
        public string IssuingAuthority { get; set; }
        public string EnforcingAuthority { get; set; }
        public string RegulatoryCitation { get; set; }
        public string LegislationRepealed { get; set; }
        public string AffectedOperations { get; set; }
        public int? AuthorId { get; set; }
        public string AuthorInformation { get; set; }
        public string RegulatoryText { get; set; }
        public string RapidComments { get; set; }
    }
}
