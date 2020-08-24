using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class Implementation
    {
        public int Idimplementation { get; set; }
        public int? Idtopic { get; set; }
        public DateTime? ImplementationDate { get; set; }
        public string Remarks { get; set; }
        public float Repetition { get; set; }
    }
}
