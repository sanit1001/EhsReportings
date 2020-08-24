namespace Ehs.Reporting.MR.Models
{
    public partial class V2ServiceBase
    {
        public string ServiceCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ServiceUrl { get; set; }
        public string ServiceLink { get; set; }
        public string SortCode { get; set; }
        public string ServicePkcolumnName { get; set; }
        public int? UserInterestSortCode { get; set; }
        public string PublicSiteServicePath { get; set; }
        public bool? IsExternalService { get; set; }
    }
}
