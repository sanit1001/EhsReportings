using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TranslatedV2ImplementationText
    {
        public int Idimplementation { get; set; }
        public string LanguageCode { get; set; }
        public string Remarks { get; set; }
        public Guid RowId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Md5 { get; set; }
        public DateTime? DateLastModified { get; set; }
        public DateTime? StartDateBase { get; set; }
        public int? UpdateTypeId { get; set; }
        public string RowStatus { get; set; }
        public DateTime? NewResearchDate { get; set; }
    }
}
