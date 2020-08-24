using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class DtqapquestionsWithGuideNotes
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
        public bool IsForOffices { get; set; }
        public bool? IsForWarehouses { get; set; }
        public string DtqQuestion { get; set; }
        public string DecTreeCode { get; set; }
        public string Description { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string ChangeNotes { get; set; }
        public string QnTitle { get; set; }
        public string RegTitle { get; set; }
        public string Citation { get; set; }
        public int? RegId { get; set; }
        public string QnGuideNote { get; set; }
    }
}
