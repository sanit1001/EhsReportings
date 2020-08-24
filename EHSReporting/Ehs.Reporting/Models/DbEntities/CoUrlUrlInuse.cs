using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoUrlUrlInuse
    {
        public string Url { get; set; }
        public string Urlcode { get; set; }
        public bool StillValid { get; set; }
        public string Reason { get; set; }
        public DateTime? DateLastChecked { get; set; }
        public bool InProgress { get; set; }
        public int Failures { get; set; }
        public DateTime? DateValidated { get; set; }
        public bool NotCurrentlyUsed { get; set; }
    }
}
