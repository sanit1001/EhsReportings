namespace Ehs.Reporting.MR.Models
{
    public partial class ClMrFeedBackMaxVersionAllMrs
    {
        public int Idtopic { get; set; }
        public string IssueOwnerCounter { get; set; }
        public string ImpactRanking { get; set; }
        public string ComplianceRanking { get; set; }
        public string ActionStatus { get; set; }
        public int Idclient { get; set; }
    }
}
