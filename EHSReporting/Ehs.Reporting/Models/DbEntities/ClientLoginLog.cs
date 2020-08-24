using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClientLoginLog
    {
        public string EmailAddress { get; set; }
        public int ValidationCode { get; set; }
        public DateTime LoginDate { get; set; }
        public string ClientUrl { get; set; }
        public string Ip { get; set; }
    }
}
