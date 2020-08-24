using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TblDeliverables
    {
        public int DlId { get; set; }
        public string DlRef { get; set; }
        public string DlDescription { get; set; }
        public string DlServiceCode { get; set; }
        public string DlCountryCode { get; set; }
        public string DlRegionCode { get; set; }
        public string DlLanguageCode { get; set; }
        public DateTime? DlValidityDate { get; set; }
        public int? DlProjectManager { get; set; }
        public DateTime? DlExpectedAccomplishDate { get; set; }
        public DateTime? DlReelAccomplishDate { get; set; }
        public DateTime? DlCreatedDate { get; set; }
        public string DlCreatedBy { get; set; }
        public DateTime? DlChangedDate { get; set; }
        public string DlChangedby { get; set; }
        public string DlNote { get; set; }
        public int? DlIndustrySector { get; set; }
        public bool? DlIncludeFederal { get; set; }
        public bool? DlIncludeGenericIndustry { get; set; }
        public bool? DlIsForOffices { get; set; }
        public bool? DlIsForWareHouses { get; set; }
    }
}
