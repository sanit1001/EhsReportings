namespace Ehs.Reporting.MR.Models
{
    public partial class ClMrAuthorities
    {
        public int Idtopic { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string LanguageCode { get; set; }
        public string City { get; set; }
        public string Hyperlink { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int AuthorityId { get; set; }
        public string RegionCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionName { get; set; }
        public string CountryName { get; set; }
        public string Fax { get; set; }
        public bool? Archived { get; set; }
    }
}
