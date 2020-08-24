using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkDefinitionText
    {
        public int RegId { get; set; }
        public int DefNumber { get; set; }
        public string LanguageCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
