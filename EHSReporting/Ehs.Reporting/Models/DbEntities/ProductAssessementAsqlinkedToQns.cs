using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ProductAssessementAsqlinkedToQns
    {
        public string CountryName { get; set; }
        public string RegionName { get; set; }
        public string DecTreeCode { get; set; }
        public string DecTreeRowStatus { get; set; }
        public DateTime DecTreeNewResearchDate { get; set; }
        public string DtqupdateType { get; set; }
        public bool DecTreeArchived { get; set; }
        public string QnCode { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string RowStatus { get; set; }
        public string QnUpdateType { get; set; }
        public bool QnArchived { get; set; }
        public string ProductTypeCode { get; set; }
        public string QnHeadingCode { get; set; }
        public string AsqHeadingCode { get; set; }
    }
}
