﻿namespace Ehs.Reporting.MR.Models
{
    public partial class TotalRegulationCounts
    {
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string LanguageCode { get; set; }
        public int? TotalRegulations { get; set; }
    }
}
