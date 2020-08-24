using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryDefinitionText
    {
        public int DefNumber { get; set; }
        public int RegId { get; set; }
        public string LanguageCode { get; set; }
        public string DefExpression { get; set; }
        public string DefDescription { get; set; }
        public string Hyperlink { get; set; }
        public string HyperlinkText { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? ValidityDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
