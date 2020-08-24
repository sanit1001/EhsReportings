using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class V2ViewImplementationDates
    {
        public int Idimplementation { get; set; }
        public int? Idtopic { get; set; }
        public DateTime? ImplementationDate { get; set; }
        public float Repetition { get; set; }
        public string LanguageCode { get; set; }
        public string Remarks { get; set; }
    }
}
