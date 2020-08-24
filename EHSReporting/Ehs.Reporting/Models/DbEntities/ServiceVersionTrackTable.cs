namespace Ehs.Reporting.MR.Models
{
    public partial class ServiceVersionTrackTable
    {
        public int Id { get; set; }
        public int IdserviceReportQueue { get; set; }
        public string ItemId { get; set; }
        public string ViewName { get; set; }
        public int RowsPublishedCount { get; set; }
    }
}
