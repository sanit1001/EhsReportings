namespace Ehs.Reporting.MR.Models
{
    public partial class QunionHeadings
    {
        public string HeadingCode { get; set; }
        public string Msc { get; set; }
        public string Ssc { get; set; }
        public string Sssc { get; set; }
        public string HeadingName { get; set; }
        public string LanguageCode { get; set; }
        public string Level { get; set; }
        public int? ParentHeadingCode { get; set; }
        public string TreeText { get; set; }
    }
}
