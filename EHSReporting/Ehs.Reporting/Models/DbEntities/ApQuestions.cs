using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ApQuestions
    {
        public string CqnCode { get; set; }
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
        public string DecTreeQn { get; set; }
        public bool IsForOffices { get; set; }
        public bool? IsForWarehouses { get; set; }
    }
}
