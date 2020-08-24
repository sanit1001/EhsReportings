using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClApScreeningQuestionText
    {
        public int ScreeningQuestionId { get; set; }
        public string LanguageCode { get; set; }
        public string ScreeningQuestion { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
