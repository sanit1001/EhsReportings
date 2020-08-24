using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoAxaptaFeed
    {
        public int Idcounter { get; set; }
        public string Email { get; set; }
        public string CellularPhone { get; set; }
        public string EnhEmplArea { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string MugShotLink { get; set; }
        public bool? IsAreaManager { get; set; }
        public bool? IsProjectManager { get; set; }
        public string Location { get; set; }
        public string CalendarId { get; set; }
        public string Nationalities { get; set; }
        public string CountryOfOrigin { get; set; }
        public DateTime? StartDateEnhesa { get; set; }
        public string SkypeId { get; set; }
        public string Biosketch { get; set; }
        public string Cvlink { get; set; }
        public string Phone { get; set; }
        public string PhoneLocal { get; set; }
    }
}
