using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class RegulationQnCitation
    {
        public int RegId { get; set; }
        public string QnCode { get; set; }
        public string Citation { get; set; }
        public string LanguageCode { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime ValidityDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public int? DocumentMapping { get; set; }
        public int Idcitation { get; set; }
        public int IdcitationFinal { get; set; }
    }
}
