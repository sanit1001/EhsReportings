namespace Ehs.Reporting.MR.Models
{
    public partial class IvoryCostLanguageIssue
    {
        public int Idcounter { get; set; }
        public string Organisation { get; set; }
        public string LnamePerson { get; set; }
        public string FnamePerson { get; set; }
        public string CountryCode { get; set; }
        public string Language { get; set; }
        public int? Idclient { get; set; }
        public string Email { get; set; }
        public string Op { get; set; }
        public string Ehs { get; set; }
        public bool E { get; set; }
        public bool Hs { get; set; }
        public bool Glb { get; set; }
        public string BasedIn { get; set; }
    }
}
