﻿using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClCmRegulationExtractedZzSw
    {
        public int Idclient { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string ServiceCode { get; set; }
        public int RegId { get; set; }
        public string LanguageCode { get; set; }
        public string SnapshotToUse { get; set; }
        public DateTime? LastModifiedDateBaseLanguage { get; set; }
        public int? MajorVersion { get; set; }
    }
}
