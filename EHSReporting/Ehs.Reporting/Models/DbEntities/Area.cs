namespace Ehs.Reporting.MR.Models
{
    public partial class Area
    {
        public int Idarea { get; set; }
        public string Area1 { get; set; }
        public bool IncludeInPicker { get; set; }
        public bool IncludeInPublicWebsite { get; set; }
        public int AreaCode { get; set; }
        public string ImagePath { get; set; }
        public int? ContinentalArea { get; set; }
    }
}
