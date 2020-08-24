using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MonitoringReports
    {
        public string ContactType { get; set; }
        public DateTime? DateArchived { get; set; }
        public string ArchivedBy { get; set; }
        public bool Archived { get; set; }
        public string Idproduct { get; set; }
        public string InternalCode { get; set; }
        public DateTime? ReportDate { get; set; }
        public int? Idcontact { get; set; }
        public DateTime? AdoptionDate { get; set; }
        public int? RegCitationlinked { get; set; }
        public int? Idstatus { get; set; }
        public string CountryCode { get; set; }
        public int Idtopic { get; set; }
        public string ContentLanguageCode { get; set; }
        public string Topic { get; set; }
        public string Rapid { get; set; }
        public DateTime? ClientReportDate { get; set; }
        public string Importance { get; set; }
        public DateTime? ImplementationDate { get; set; }
        public float? Repetition { get; set; }
        public string Remarks { get; set; }
        public int WorldAreaId { get; set; }
        public DateTime? ReadyforPublicationDate { get; set; }
        public string ReadyforPublicationBy { get; set; }
        public bool ReadyforPublication { get; set; }
        public bool ReadyforQc { get; set; }
        public string ReadyforQcby { get; set; }
        public DateTime? ReadyforQcdate { get; set; }
    }
}
