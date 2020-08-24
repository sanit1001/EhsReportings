using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryCoAllServiceVersion
    {
        public string ServiceCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string LanguageCode { get; set; }
        public string SetCode { get; set; }
        public int IndCode { get; set; }
        public float? RepCode { get; set; }
        public DateTime? ExpectedPublicationDate { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public string ProductTypeCode { get; set; }
        public short AvailableItemCount { get; set; }
        public short NotIncludedCount { get; set; }
        public bool? Fake { get; set; }
    }
}
