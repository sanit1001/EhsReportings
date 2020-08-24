using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class AnswerDtqText
    {
        public int Idanswer { get; set; }
        public string LanguageCode { get; set; }
        public DateTime CreateDate { get; set; }
        public string Comment { get; set; }
    }
}
