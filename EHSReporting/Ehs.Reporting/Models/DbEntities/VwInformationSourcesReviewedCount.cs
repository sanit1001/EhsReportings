using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class VwInformationSourcesReviewedCount
    {
        public int? UrlCount { get; set; }
        public DateTime? LastReviewed { get; set; }
        public int Idcounter { get; set; }
        public string Logon { get; set; }
        public string CountryCode { get; set; }
        public string LanguageCode { get; set; }
        public string CountryName { get; set; }
    }
}
