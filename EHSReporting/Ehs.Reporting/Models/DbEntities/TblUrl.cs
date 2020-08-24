using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TblUrl
    {
        public string Urlcode { get; set; }
        public string Url { get; set; }
        public DateTime? DateLastChecked { get; set; }
        public bool StillValid { get; set; }
        public string Reason { get; set; }
        public bool InProgress { get; set; }
        public int Failures { get; set; }
        public DateTime? DateValidated { get; set; }
        public bool NotCurrentlyUsed { get; set; }
        public int StatusCode { get; set; }
        public bool? IsVersionable { get; set; }
    }
}
