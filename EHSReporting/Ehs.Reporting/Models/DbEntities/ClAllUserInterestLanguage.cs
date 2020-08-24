namespace Ehs.Reporting.MR.Models
{
    public partial class ClAllUserInterestLanguage
    {
        public string EmailAddress { get; set; }
        public string ContentLanguageCode { get; set; }
        public byte OrderOfPreference { get; set; }
        public int? Idclient { get; set; }
    }
}
