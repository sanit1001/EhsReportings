﻿using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class DectreeLinkedToRegulation
    {
        public string DecTreeCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string LanguageCode { get; set; }
        public string RowStatus { get; set; }
        public DateTime NewResearchDate { get; set; }
        public int RegId { get; set; }
    }
}
