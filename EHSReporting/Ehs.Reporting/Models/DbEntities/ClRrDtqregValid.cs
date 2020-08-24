namespace Ehs.Reporting.MR.Models
{
    public partial class ClRrDtqregValid
    {
        public int RegId { get; set; }
        public string DecTreeCode { get; set; }
        public string LanguageCodeHeadings { get; set; }
        public string LanguageCodeDtqs { get; set; }
        public string RegionCode { get; set; }
        public string CountryCodeDtq { get; set; }
        public string HeadingCode { get; set; }
        public int Idclient { get; set; }
        public byte DtqmajorVersion { get; set; }
    }
}
