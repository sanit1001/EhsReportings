namespace Ehs.Reporting.MR.Models
{
    public partial class ApwordCounts
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string LanguageCode { get; set; }
        public short? QnTitleNbrOfWords { get; set; }
        public short? QnGuideNoteNbrOfWords { get; set; }
        public string HeadingCode { get; set; }
        public string QnCode { get; set; }
    }
}
