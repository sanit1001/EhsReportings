namespace Ehs.Reporting.MR.Models
{
    public partial class ApquestionsChangeReport
    {
        public bool IsMajorChange { get; set; }
        public string Description { get; set; }
        public string QnCode { get; set; }
        public string LanguageCode { get; set; }
        public string RowStatus { get; set; }
        public string Qn { get; set; }
        public string QnGuideNote { get; set; }
        public string LastModifiedDate { get; set; }
        public string QnTitle { get; set; }
        public string NewResearchDate { get; set; }
        public string ChangeNotes { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public byte MajorVersion { get; set; }
        public byte MinorVersion { get; set; }
        public string VersionNumber { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string HeadingCod { get; set; }
        public bool? IsForWarehouses { get; set; }
        public bool IsForOffices { get; set; }
    }
}
