using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ViewHeadingSubSub
    {
        public string HeadingCode { get; set; }
        public string LanguageCode { get; set; }
        public string HeadingName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string GeneralDescription { get; set; }
        public string Main { get; set; }
        public string MainSortCode { get; set; }
        public string Sub { get; set; }
        public string SubSortCode { get; set; }
        public string SubSub { get; set; }
        public string SubSubSortCode { get; set; }
    }
}
