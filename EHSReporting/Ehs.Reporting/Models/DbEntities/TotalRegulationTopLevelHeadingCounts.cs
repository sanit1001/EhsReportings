﻿namespace Ehs.Reporting.MR.Models
{
    public partial class TotalRegulationTopLevelHeadingCounts
    {
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string LanguageCode { get; set; }
        public string TopLevelHeadingCode { get; set; }
        public int? TotalRegulations { get; set; }
    }
}
