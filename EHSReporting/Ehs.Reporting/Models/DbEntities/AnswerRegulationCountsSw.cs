namespace Ehs.Reporting.MR.Models
{
    public partial class AnswerRegulationCountsSw
    {
        public int Idclient { get; set; }
        public string Facilitycode { get; set; }
        public string Countrycode { get; set; }
        public string Regioncode { get; set; }
        public string Servicecode { get; set; }
        public string LanguageCode { get; set; }
        public int? ApplicableRegulations { get; set; }
        public int? NotApplicableRegulations { get; set; }
        public int? UnsureRegulations { get; set; }
        public int? RequiresRevalidationRegulations { get; set; }
    }
}
