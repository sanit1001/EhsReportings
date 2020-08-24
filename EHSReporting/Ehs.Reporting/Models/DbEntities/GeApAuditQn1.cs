using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class GeApAuditQn1
    {
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string HeadingCode { get; set; }
        public string Qn { get; set; }
        public string QnGuideNote { get; set; }
        public string LanguageCode { get; set; }
        public DateTime? ValidityDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool IsRevised { get; set; }
        public bool IsForOffices { get; set; }
        public bool Archived { get; set; }
        public int SortCode { get; set; }
        public bool? IsForWarehouses { get; set; }
        public string SetCode { get; set; }
        public string QnCode { get; set; }
        public DateTime NewResearchDate { get; set; }
        public DateTime NewResearchDateQnText { get; set; }
    }
}
