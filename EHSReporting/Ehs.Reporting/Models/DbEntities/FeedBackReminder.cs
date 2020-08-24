using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class FeedBackReminder
    {
        public int Idclient { get; set; }
        public int Idtopic { get; set; }
        public int? PeriodInMonths { get; set; }
        public DateTime? LastReminded { get; set; }
    }
}
