using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class V3LegislationD
    {
        public int A { get; set; }
        public DateTime? B { get; set; }
        public string C { get; set; }
        public int D { get; set; }
        public DateTime? E { get; set; }
        public string F { get; set; }
        public int RegId { get; set; }
        public int RegulationType { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public string RegulationReference { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string AmendmentCode { get; set; }
        public DateTime? AmendmentDate { get; set; }
        public string LanguageCode { get; set; }
        public string AmendmentTitle { get; set; }
        public string AmendmentRef { get; set; }
        public string Hyperlink { get; set; }
        public bool ArchiveA { get; set; }
        public bool ArchiveR { get; set; }
    }
}
