using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClHlHelpLinkBase
    {
        public int IdhelpLink { get; set; }
        public int Idclient { get; set; }
        public string Hyperlink { get; set; }
        public DateTime? DateOfAnswer { get; set; }
        public string RequestingUsername { get; set; }
        public string ContactingUsername { get; set; }
    }
}
