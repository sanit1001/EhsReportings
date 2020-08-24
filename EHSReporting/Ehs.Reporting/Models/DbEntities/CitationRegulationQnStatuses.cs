namespace Ehs.Reporting.MR.Models
{
    public partial class CitationRegulationQnStatuses
    {
        public int RegId { get; set; }
        public int Idcitation { get; set; }
        public string CitationRowStatus { get; set; }
        public bool RegArchived { get; set; }
        public string RegRowStatus { get; set; }
        public string QnCode { get; set; }
        public string QnRowStatus { get; set; }
        public string QnCountryCode { get; set; }
        public string QnRegioncoe { get; set; }
        public bool QnArchived { get; set; }
        public string QnHeadingCode { get; set; }
    }
}
