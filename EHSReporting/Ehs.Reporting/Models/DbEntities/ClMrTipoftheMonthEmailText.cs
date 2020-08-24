namespace Ehs.Reporting.MR.Models
{
    public partial class ClMrTipoftheMonthEmailText
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public string LanguageCode { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
