using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClRrDtqValid
    {
        public string LanguageCodeHeadings { get; set; }
        public string LanguageCodeDtqs { get; set; }
        public string DecTreeCode { get; set; }
        public string RegionCode { get; set; }
        public string HeadingCode { get; set; }
        public string HeadingName { get; set; }
        public string DecTreeQn { get; set; }
        public string DecTreeGuideNote { get; set; }
        public DateTime? ValidityDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int Idclient { get; set; }
        public string CountryCodeDtq { get; set; }
        public string FacilityCode { get; set; }
        public DateTime? DtqlastModifiedDate { get; set; }
        public byte DtqmajorVersion { get; set; }
        public string DtqregionCode { get; set; }
    }
}
