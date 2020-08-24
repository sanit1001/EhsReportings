using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class RegRegStatWithIndustrySector
    {
        public int RegId { get; set; }
        public string IndustrySector { get; set; }
        public string Country { get; set; }
        public string RegionName { get; set; }
        public string ReferenceDate { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string RegTitle { get; set; }
    }
}
