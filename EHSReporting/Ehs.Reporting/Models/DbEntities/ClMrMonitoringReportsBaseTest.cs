using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClMrMonitoringReportsBaseTest
    {
        public int Idclient { get; set; }
        public int IdcontentProxy { get; set; }
        public int IdservicesProxy { get; set; }
        public int Idtopic { get; set; }
        public DateTime? ClientReportDate { get; set; }
        public string Importance { get; set; }
        public string SetCode { get; set; }
        public string CountryCode { get; set; }
        public int? Idstatus { get; set; }
        public int? RegCitationlinked { get; set; }
        public DateTime? AdoptionDate { get; set; }
        public int? Idcontact { get; set; }
        public DateTime? ReportDate { get; set; }
        public string InternalCode { get; set; }
        public string Idproduct { get; set; }
        public bool Archived { get; set; }
        public string ContactType { get; set; }
        public string RegionCode { get; set; }
        public string StatusGroup { get; set; }
    }
}
