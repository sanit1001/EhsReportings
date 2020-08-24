namespace Ehs.Reporting.MR.Models
{
    public partial class AllRegulationsInEnglish
    {
        public int RegId { get; set; }
        public string CreateDate { get; set; }
        public string LastModifiedDate { get; set; }
        public string RegTitle { get; set; }
        public bool Active { get; set; }
        public bool Archive { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
    }
}
