using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class DtqsLinkedToRegulations
    {
        public string CountryName { get; set; }
        public string RegionName { get; set; }
        public string DecTreeCode { get; set; }
        public string DecTreeRowStatus { get; set; }
        public DateTime DecTreeNewResearchDate { get; set; }
        public string DtqupdateType { get; set; }
        public int RegId { get; set; }
        public string RegUpdateType { get; set; }
        public DateTime RegulationnewResearchDate { get; set; }
        public string RegulationrowStatus { get; set; }
        public bool DecTreeArchived { get; set; }
        public bool RegArchived { get; set; }
    }
}
