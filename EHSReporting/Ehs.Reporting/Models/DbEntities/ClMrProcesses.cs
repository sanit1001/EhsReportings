using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClMrProcesses
    {
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
