using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class RegulationQnCitationNew
    {
        public string QnCode { get; set; }
        public int RegId { get; set; }
        public string Citation { get; set; }
        public string LanguageCode { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string DocumentMapping { get; set; }
        public int Idcitation { get; set; }
        public int IdcitationFinal { get; set; }
        public DateTime ValidityDate { get; set; }
        public string Md5 { get; set; }
    }
}
