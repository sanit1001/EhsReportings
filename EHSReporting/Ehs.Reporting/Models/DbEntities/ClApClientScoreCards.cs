namespace Ehs.Reporting.MR.Models
{
    public partial class ClApClientScoreCards
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int? StartLine { get; set; }
        public string LastLineRange { get; set; }
        public int? StartPage { get; set; }
        public int? TotalPage { get; set; }
    }
}
