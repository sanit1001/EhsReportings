namespace Ehs.Reporting.MR.Models
{
    public partial class EmailAlertsListOfUsersWithUserInterests
    {
        public string ClientName { get; set; }
        public string Scope { get; set; }
        public string Email { get; set; }
        public string ClientLongName { get; set; }
        public string UseSnapshotDb { get; set; }
        public string UseServerInstance { get; set; }
        public int? MonthOfLatestReportDate { get; set; }
        public int? YearOfLatestReportDate { get; set; }
        public int Glb { get; set; }
        public string Ehs { get; set; }
        public string Op { get; set; }
        public int E { get; set; }
        public int Hs { get; set; }
        public int? CountriesOfInterest { get; set; }
        public int MrreportAlert { get; set; }
        public string Language { get; set; }
        public int Idcounter { get; set; }
        public int? Idclient { get; set; }
        public string LnamePerson { get; set; }
        public string FnamePerson { get; set; }
    }
}
