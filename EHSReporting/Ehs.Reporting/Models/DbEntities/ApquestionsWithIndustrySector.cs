using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ApquestionsWithIndustrySector
    {
        public string QnCode { get; set; }
        public string QnText { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string RegionName { get; set; }
        public string RegionCode { get; set; }
        public string HeadingCode { get; set; }
        public string HeadingName { get; set; }
        public bool IsForOffices { get; set; }
        public bool? IsForWarehouses { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string ChangeNotes { get; set; }
        public string RegTitle { get; set; }
        public string Citation { get; set; }
        public int? RegId { get; set; }
        public int? IndustrySector { get; set; }
    }
}
