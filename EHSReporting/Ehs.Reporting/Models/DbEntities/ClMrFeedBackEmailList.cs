using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClMrFeedBackEmailList
    {
        public int Idclient { get; set; }
        public int Idtopic { get; set; }
        public int? Version { get; set; }
        public string LnamePerson { get; set; }
        public string FnamePerson { get; set; }
        public string Email { get; set; }
        public string LanguageCodeTopic { get; set; }
        public string Topic { get; set; }
        public string Rapid { get; set; }
        public string CountryCode { get; set; }
        public string LanguageCodeCountry { get; set; }
        public string CountryName { get; set; }
        public int? PeriodInMonths { get; set; }
        public DateTime LastModified { get; set; }
        public short IsMaxVersion { get; set; }
    }
}
