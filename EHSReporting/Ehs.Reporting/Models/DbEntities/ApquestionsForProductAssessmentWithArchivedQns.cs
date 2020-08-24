using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ApquestionsForProductAssessmentWithArchivedQns
    {
        public string CqnCode { get; set; }
        public bool Archived { get; set; }
        public string CqnText { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string RegionName { get; set; }
        public string RegionCode { get; set; }
        public string HeadingCode { get; set; }
        public string HeadingName { get; set; }
        public string MqnCode { get; set; }
        public string LinkType { get; set; }
        public string LinkNotes { get; set; }
        public string DecTreeCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string QnGuideNote { get; set; }
        public DateTime? ValidityDate { get; set; }
        public string ReleaseNote { get; set; }
        public string ReleaseComment { get; set; }
        public string HeadingCodeText { get; set; }
        public int? TypeId { get; set; }
        public string ProductTypeCode { get; set; }
        public string TopicAreaText { get; set; }
    }
}
