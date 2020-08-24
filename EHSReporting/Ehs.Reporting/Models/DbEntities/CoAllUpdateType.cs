using System.Collections.Generic;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoAllUpdateType
    {
        public CoAllUpdateType()
        {
            TrackingRegulationMonitoringReport = new HashSet<TrackingRegulationMonitoringReport>();
            TrackingTopicHeading = new HashSet<TrackingTopicHeading>();
            TrackingV2ImplementationBase = new HashSet<TrackingV2ImplementationBase>();
            TrackingV2ImplementationText = new HashSet<TrackingV2ImplementationText>();
            TrackingV2MrBusinessImpactBase = new HashSet<TrackingV2MrBusinessImpactBase>();
            TrackingV2MrBusinessImpactText = new HashSet<TrackingV2MrBusinessImpactText>();
            TrackingV2TopicBase = new HashSet<TrackingV2TopicBase>();
            TrackingV2TopicRegion = new HashSet<TrackingV2TopicRegion>();
            TrackingV2TopicText = new HashSet<TrackingV2TopicText>();
        }

        public int UpdateTypeId { get; set; }
        public bool IsMajorChange { get; set; }
        public string Description { get; set; }
        public string SortOrder { get; set; }

        public virtual ICollection<TrackingRegulationMonitoringReport> TrackingRegulationMonitoringReport { get; set; }
        public virtual ICollection<TrackingTopicHeading> TrackingTopicHeading { get; set; }
        public virtual ICollection<TrackingV2ImplementationBase> TrackingV2ImplementationBase { get; set; }
        public virtual ICollection<TrackingV2ImplementationText> TrackingV2ImplementationText { get; set; }
        public virtual ICollection<TrackingV2MrBusinessImpactBase> TrackingV2MrBusinessImpactBase { get; set; }
        public virtual ICollection<TrackingV2MrBusinessImpactText> TrackingV2MrBusinessImpactText { get; set; }
        public virtual ICollection<TrackingV2TopicBase> TrackingV2TopicBase { get; set; }
        public virtual ICollection<TrackingV2TopicRegion> TrackingV2TopicRegion { get; set; }
        public virtual ICollection<TrackingV2TopicText> TrackingV2TopicText { get; set; }
    }
}
