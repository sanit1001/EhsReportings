using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoAllMyActionItems
    {
        public string Description { get; set; }
        public int ActionId { get; set; }
        public string Logon { get; set; }
        public DateTime? ReportDate { get; set; }
        public DateTime? LastReviewed { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
    }
}
