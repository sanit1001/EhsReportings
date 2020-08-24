using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CitationMapSqlOracle
    {
        public int Idcitation { get; set; }
        public int RegId { get; set; }
        public string FoundationCe { get; set; }
        public string StructureElementCe { get; set; }
        public DateTimeOffset TracingDt { get; set; }
    }
}
