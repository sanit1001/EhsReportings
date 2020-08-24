using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryIntro
    {
        public string HeadingCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string BaseLanguageCode { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public int IntroId { get; set; }
    }
}
