namespace Ehs.Reporting.MR.Models
{
    public partial class UserInterestsCountryRegionPreferences
    {
        public int Idclient { get; set; }
        public string WebSite { get; set; }
        public string ClientLongName { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ContentLanguageCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string SIndex { get; set; }
        public bool EnhesaFlash { get; set; }
        public int PreferenceType { get; set; }
        public int MailAlertFrequency { get; set; }
        public int ServiceUpdateFrequency { get; set; }
        public int EnhesaServiceUpdate { get; set; }
        public int Webinards { get; set; }
    }
}
