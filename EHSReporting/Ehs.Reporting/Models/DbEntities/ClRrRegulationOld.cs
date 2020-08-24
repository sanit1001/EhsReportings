namespace Ehs.Reporting.MR.Models
{
    public partial class ClRrRegulationOld
    {
        public int RegId { get; set; }
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string HeadingCode { get; set; }
        public string RegionCode { get; set; }
        public string CountryCode { get; set; }
        public string SortCode { get; set; }
        public int RegulationType { get; set; }
        public string RegulationReference { get; set; }
        public int IndCode { get; set; }
        public byte RegMajorVersion { get; set; }
    }
}
