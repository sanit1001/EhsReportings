using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CmRegAnswers
    {
        public int RegId { get; set; }
        public string Answer { get; set; }
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string AnswerCreateBy { get; set; }
        public DateTime AnswerCreateDate { get; set; }
    }
}
