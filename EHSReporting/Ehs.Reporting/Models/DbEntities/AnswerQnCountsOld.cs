namespace Ehs.Reporting.MR.Models
{
    public partial class AnswerQnCountsOld
    {
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string LanguageCode { get; set; }
        public int? CompliantRequirements { get; set; }
        public int? ActionRequiredRequirements { get; set; }
        public int? NotApplicableRequirements { get; set; }
        public int? UnsureRequirements { get; set; }
        public int? RequiresRevalidationRequirements { get; set; }
    }
}
