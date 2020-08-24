using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClRrDtqchildsValid
    {
        public string DecTreeCodeParent { get; set; }
        public string DecTreeCodeChild { get; set; }
        public string DecTreeQn { get; set; }
        public string DecTreeGuideNote { get; set; }
        public DateTime? ValidityDate { get; set; }
        public string LanguageCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public byte DtqmajorVersion { get; set; }
    }
}
