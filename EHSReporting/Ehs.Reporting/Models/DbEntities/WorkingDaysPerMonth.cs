using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class WorkingDaysPerMonth
    {
        public string CountryCode { get; set; }
        public DateTime FirstOfTheMonth { get; set; }
        public int WorkingDaysThisMonth { get; set; }
    }
}
