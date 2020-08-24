using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClRrReg1Inactive
    {
        public string HeadingCode { get; set; }
        public int RegId { get; set; }
        public int RegulationType { get; set; }
        public string CountryCode { get; set; }
        public string LanguageCodeRegs { get; set; }
        public DateTime ValidityDate { get; set; }
        public string RegionCode { get; set; }
        public string RegulationReference { get; set; }
        public string SortCode { get; set; }
        public string RegTitle { get; set; }
        public int Idclient { get; set; }
        public byte RegMajorVersion { get; set; }
    }
}
