using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClApScoreCardClientBack
    {
        public int ScoreCardId { get; set; }
        public DateTime SubmitDate { get; set; }
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
    }
}
