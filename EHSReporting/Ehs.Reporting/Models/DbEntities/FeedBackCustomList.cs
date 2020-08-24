namespace Ehs.Reporting.MR.Models
{
    public partial class FeedBackCustomList
    {
        public int IdfeedBackCustomList { get; set; }
        public int? Idclient { get; set; }
        public string ListName { get; set; }
        public string ContentPanelName { get; set; }
        public bool? IsShown { get; set; }
        public string Note { get; set; }
    }
}
