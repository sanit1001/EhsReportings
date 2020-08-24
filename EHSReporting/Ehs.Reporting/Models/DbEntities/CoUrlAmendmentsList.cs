using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoUrlAmendmentsList
    {
        public string AmendmentCode { get; set; }
        public string LanguageCode { get; set; }
        public string Hyperlink { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
