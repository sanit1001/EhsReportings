using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class Iislog
    {
        public long LogId { get; set; }
        public DateTime LogDateTime { get; set; }
        public string SsiteName { get; set; }
        public string ScomputerName { get; set; }
        public string Sip { get; set; }
        public string CsMethod { get; set; }
        public string CsUriStem { get; set; }
        public string CsUriQuery { get; set; }
        public string Sport { get; set; }
        public string CsUserName { get; set; }
        public string Cip { get; set; }
        public string CsVersion { get; set; }
        public string CsUserAgent { get; set; }
        public string CsCookie { get; set; }
        public string CsReferer { get; set; }
        public string CsHost { get; set; }
        public string ScStatus { get; set; }
        public string ScSubStatus { get; set; }
        public string ScWin32Status { get; set; }
        public string ScBytes { get; set; }
        public string CsBytes { get; set; }
        public string TimeTaken { get; set; }
        public string FileName { get; set; }
    }
}
