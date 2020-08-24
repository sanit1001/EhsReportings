using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClRrDtqInfoText
    {
        public string DecTreeCode { get; set; }
        public string LanguageCodeDtq { get; set; }
        public string LanguageCodeRegulations { get; set; }
        public string DecTreeGuideNote { get; set; }
        public int RegId { get; set; }
        public string RegTitle { get; set; }
        public string FacilityCode { get; set; }
        public int Idclient { get; set; }
        public DateTime ValidityDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string LanguageCode { get; set; }
        public byte DtqmajorVersion { get; set; }
    }
}
