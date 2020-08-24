namespace Ehs.Reporting.MR.Models
{
    public partial class ClientDistributionList
    {
        public string WebSite { get; set; }
        public string Email { get; set; }
        public string ClientLongName { get; set; }
        public int MrreportAlert { get; set; }
        public int Idcounter { get; set; }
        public int? Idclient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
    }
}
