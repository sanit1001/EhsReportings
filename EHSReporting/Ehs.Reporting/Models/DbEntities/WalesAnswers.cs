using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class WalesAnswers
    {
        public string QnCode { get; set; }
        public string Answer { get; set; }
        public string AnswerCreateBy { get; set; }
        public DateTime? AnswerCreateDate { get; set; }
        public string AnswerLastModifiedBy { get; set; }
    }
}
