using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ServiceVersionQueue
    {
        public int IdserviceReportQueue { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string LanguageCode { get; set; }
        public string SetCode { get; set; }
        public int IndCode { get; set; }
        public string QueueStatus { get; set; }
        public string ErrorMsg { get; set; }
        public string CreatedBy { get; set; }
        public string Email { get; set; }
        public DateTime ResearchDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
