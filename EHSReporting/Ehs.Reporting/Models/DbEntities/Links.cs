using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class Links
    {
        public string Url { get; set; }
        public string WebsiteComments { get; set; }
        public DateTime? LastReviewed { get; set; }
        public string SubscriptionDetails { get; set; }
        public string CostDetails { get; set; }
        public bool MonitoringSource { get; set; }
        public bool ChemicalSource { get; set; }
        public string MonitoringPriority { get; set; }
        public bool Ministry { get; set; }
        public bool GovernmentPublisher { get; set; }
        public string Category { get; set; }
    }
}
