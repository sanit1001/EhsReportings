using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoUrlMonitoringReportsList
    {
        public int Idtopic { get; set; }
        public string LanguageCode { get; set; }
        public string CountryCode { get; set; }
        public int? RegCitationlinked { get; set; }
        public string Summary { get; set; }
        public string IssuingAuthority { get; set; }
        public string EnforcingAuthority { get; set; }
        public string RegulatoryCitation { get; set; }
        public string RegulatoryText { get; set; }
        public bool Archived { get; set; }
        public DateTime? DateLastModified { get; set; }
    }
}
