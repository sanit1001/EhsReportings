using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkV2TopicRegion
    {
        public int Idtopic { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
