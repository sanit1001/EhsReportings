using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClAllClientRegionLang
    {
        public int Idclient { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string LanguageCode { get; set; }
        public DateTime? StartOfDelivery { get; set; }
        public DateTime? EndOfDelivery { get; set; }
        public bool? WebDelivery { get; set; }
        public bool FtpFile { get; set; }
        public bool TakeLatestCp { get; set; }
        public DateTime? FroozenCpdate { get; set; }
        public DateTime? FrozenRrdate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsRrupdate { get; set; }
        public bool IncludeEnglish { get; set; }
        public string SnapShotToUse { get; set; }
        public DateTime? ServiceReportDate { get; set; }
        public bool? IncludeFields { get; set; }
        public bool IsClosedBox { get; set; }
    }
}
