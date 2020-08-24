using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkQnText
    {
        public string QnCode { get; set; }
        public string LanguageCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
        public int AutoId { get; set; }
    }
}
