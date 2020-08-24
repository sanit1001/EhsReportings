using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class MrPerCountryRegionStatusReportdate
    {
        public int Idtopic { get; set; }
        public string ReportDate { get; set; }
        public string LanguageCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string RowStatus { get; set; }
        public DateTime NewResearchDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DateLastModified { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? AdoptionDate { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string ModifiedBy { get; set; }
    }
}
