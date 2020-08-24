using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClApScoreCardText
    {
        public int ScoreCardId { get; set; }
        public string QnCode { get; set; }
        public string LanguageCode { get; set; }
        public string OriginalQn { get; set; }
        public string OriginalQnGuideNote { get; set; }
        public string OriginalCitation { get; set; }
        public string OriginalCitationLink { get; set; }
        public string OriginalRelatedDocuments { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
