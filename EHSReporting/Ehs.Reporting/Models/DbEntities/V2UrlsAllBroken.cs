using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class V2UrlsAllBroken
    {
        public string CountryCode { get; set; }
        public string Urlcode { get; set; }
        public string Url { get; set; }
        public string Reason { get; set; }
        public string Pk { get; set; }
        public string Title { get; set; }
        public string RecordType { get; set; }
        public string LanguageCode { get; set; }
        public DateTime? DateLastChecked { get; set; }
        public int Failures { get; set; }
        public string RegionCode { get; set; }
        public bool StillValid { get; set; }
    }
}
