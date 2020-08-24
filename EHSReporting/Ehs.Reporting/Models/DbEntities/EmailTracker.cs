using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class EmailTracker
    {
        public int Idcounter { get; set; }
        public int Idclient { get; set; }
        public DateTime Dateemailing { get; set; }
        public int? Counts { get; set; }
    }
}
