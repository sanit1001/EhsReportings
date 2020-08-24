using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClAllAnswerDtq
    {
        public int Idclient { get; set; }
        public string DecTreeCode { get; set; }
        public string Answer { get; set; }
        public string AnswerCreateBy { get; set; }
        public DateTime? AnswerCreateDate { get; set; }
        public string AnswerLastModifiedBy { get; set; }
        public DateTime? AnswerLastModifiedDate { get; set; }
        public string FacilityCode { get; set; }
        public string Comment { get; set; }
        public string CommentCreateBy { get; set; }
        public DateTime? CommentCreateDate { get; set; }
        public string CommentLastModifiedBy { get; set; }
        public DateTime? DtqlastModifiedDate { get; set; }
        public DateTime? CommentLastModifiedDate { get; set; }
        public byte MajorVersion { get; set; }
    }
}
