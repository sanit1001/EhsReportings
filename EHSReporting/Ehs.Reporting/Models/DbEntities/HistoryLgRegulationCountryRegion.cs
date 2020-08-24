using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryLgRegulationCountryRegion
    {
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public int RegId { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public string AutoId { get; set; }
    }
}
