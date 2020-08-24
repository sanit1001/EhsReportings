namespace Ehs.Reporting.MR.Models
{
    public partial class ClMrFeedBackMailingListValid
    {
        public int Idcounter { get; set; }
        public string LnamePerson { get; set; }
        public string FnamePerson { get; set; }
        public string Organisation { get; set; }
        public string Email { get; set; }
        public string CountryCode { get; set; }
        public string LanguagesOfPreference { get; set; }
        public string Op { get; set; }
        public string Ehs { get; set; }
        public string Countries { get; set; }
        public bool Glb { get; set; }
        public bool EnhesaFlash { get; set; }
        public int? Idclient { get; set; }
    }
}
