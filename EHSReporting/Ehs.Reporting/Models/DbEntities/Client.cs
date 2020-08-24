using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class Client
    {
        public int Idclient { get; set; }
        public string ClientName { get; set; }
        public string UseSnapshotDb { get; set; }
        public string UseServerInstance { get; set; }
        public DateTime? LatestReportDate { get; set; }
        public int IdcontentProxy { get; set; }
        public int IdservicesProxy { get; set; }
        public string ClientLongName { get; set; }
        public string WebSiteVariations { get; set; }
        public DateTime? EarliestReportDate { get; set; }
        public string Scope { get; set; }
        public string FieldOp { get; set; }
        public short? MonthsInPeriod { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool? TrustedIp { get; set; }
        public bool? Frontpage { get; set; }
        public string BounceFrom { get; set; }
        public string BounceTo { get; set; }
        public string Ipnumbers { get; set; }
        public string GroupName { get; set; }
        public bool IsAbagClient { get; set; }
        public bool IsApespecialClient { get; set; }
        public bool IsSimpleMrExportToXls { get; set; }
        public bool IsAfeedBackClient { get; set; }
        public bool? TakeLatestBi { get; set; }
        public DateTime? BifroozenDate { get; set; }
        public bool? NewTemplate { get; set; }
        public bool IsArrseparatedRegions { get; set; }
        public bool? IsTakingCommentsMr { get; set; }
        public bool SkipNonContractedServices { get; set; }
        public bool GetsHelpLine { get; set; }
        public int Status { get; set; }
        public int ClientManager { get; set; }
        public bool IsRankingMrEmailAlert { get; set; }
        public bool HasMappedHeadings { get; set; }
        public int ClientIndustrySector { get; set; }
        public int AccountManager { get; set; }
        public string ClientLogoUrl { get; set; }
        public bool ShowLogoOnPublicSite { get; set; }
        public string GuidanceLink { get; set; }
        public bool HasOwnResourceNames { get; set; }
        public string DistributionNote { get; set; }
        public string PlatformProvider { get; set; }
        public int IdcontentProxyCpBi { get; set; }
        public string AuthS3bucketName { get; set; }
    }
}
