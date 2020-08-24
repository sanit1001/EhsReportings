using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClRrDtqanswersValid
    {
        public int Idanswer { get; set; }
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string Idcontact { get; set; }
        public string Dtqcode { get; set; }
        public DateTime? ValidityDate { get; set; }
        public int? RegId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Answer { get; set; }
        public string Comment { get; set; }
        public string LanguageCode { get; set; }
        public int AnswerMajorVersion { get; set; }
    }
}
