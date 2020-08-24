using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class Facilty
    {
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public DateTime CreateDate { get; set; }
        public string Owner { get; set; }
        public string ServiceCode { get; set; }
        public bool Archived { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsVisibleInIssueManager { get; set; }
        public bool IncludeAllRegions { get; set; }
        public bool ExcludeRequirements { get; set; }
    }
}
