using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkQnImage
    {
        public string QnCode { get; set; }
        public string ImageLink { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
