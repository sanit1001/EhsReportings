namespace Ehs.Reporting.MR.Models
{
    public partial class RegulationDtqcounts
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public int RegId { get; set; }
        public int? NumberOfDtq { get; set; }
        public string RegTitle { get; set; }
    }
}
