using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ServiceVersionWareHouseFullDetails
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string IndName { get; set; }
        public string Frequency { get; set; }
        public string ServiceCode { get; set; }
        public string LanguageCode { get; set; }
        public string SetCode { get; set; }
        public DateTime ResearchDate { get; set; }
        public DateTime BoxPublicationDate { get; set; }
        public DateTime? ExpectedPublicationDate { get; set; }
        public string RowStatus { get; set; }
        public int UpdateTypeId { get; set; }
        public string ChangeNotes { get; set; }
        public byte MajorVersion { get; set; }
        public byte MinorVersion { get; set; }
    }
}
