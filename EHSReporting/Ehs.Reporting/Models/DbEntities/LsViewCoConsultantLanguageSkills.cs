namespace Ehs.Reporting.MR.Models
{
    public partial class LsViewCoConsultantLanguageSkills
    {
        public int Idcounter { get; set; }
        public string LanguageName { get; set; }
        public string LanguageCode { get; set; }
        public int? SkillLevel { get; set; }
        public string LevelDescription { get; set; }
        public int? Speaking { get; set; }
        public int? Reading { get; set; }
        public int? Writing { get; set; }
        public string Speakingdesc { get; set; }
        public string Readingdesc { get; set; }
        public string Writingdesc { get; set; }
    }
}
