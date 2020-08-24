using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CpFrozen
    {
        public int IntroId { get; set; }
        public string LanguageCode { get; set; }
        public DateTime FreezeDate { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string HeadingCode { get; set; }
        public string Intro { get; set; }
        public string BackgroundInfo { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? ValidityDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? QcedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ProofedDate { get; set; }
        public string QcedBy { get; set; }
        public string ProofedBy { get; set; }
        public string Md5 { get; set; }
    }
}
