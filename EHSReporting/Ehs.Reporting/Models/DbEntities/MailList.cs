namespace Ehs.Reporting.MR.Models
{
    public partial class MailList
    {
        public int Idcounter { get; set; }
        public string Language { get; set; }
        public string Op { get; set; }
        public string Ehs { get; set; }
        public string CountryCode { get; set; }
        public bool E { get; set; }
        public bool Hs { get; set; }
        public bool? Glb { get; set; }
    }
}
