using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class FeedBackVersions
    {
        public int Idclient { get; set; }
        public int Idtopic { get; set; }
        public DateTime LastModified { get; set; }
        public int Version { get; set; }
        public string IssueOwner { get; set; }
        public string IssueOwnerCounter { get; set; }
        public string ImpactRanking { get; set; }
        public string ComplianceRanking { get; set; }
        public string ActionStatus { get; set; }
        public string NetworkTeamAssessment { get; set; }
        public string CompliancePlan { get; set; }
        public string Notes { get; set; }
        public string Advocacy { get; set; }
        public string MiscField2 { get; set; }
        public string MiscField3 { get; set; }
        public int? Expr1 { get; set; }
        public string LnamePerson { get; set; }
        public string FnamePerson { get; set; }
        public string SIndex { get; set; }
        public string Email { get; set; }
        public string CreatedBy { get; set; }
    }
}
