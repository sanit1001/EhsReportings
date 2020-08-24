using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryDecTree
    {
        public string DecTreeCode { get; set; }
        public string CountryCode { get; set; }
        public string GeographicType { get; set; }
        public string RegionCode { get; set; }
        public bool Archived { get; set; }
        public string BaseLanguageCode { get; set; }
        public string ArchivedBy { get; set; }
        public DateTime? DateArchived { get; set; }
        public string ReleaseNote { get; set; }
        public string ReleaseComment { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public string AutoId { get; set; }
    }
}
