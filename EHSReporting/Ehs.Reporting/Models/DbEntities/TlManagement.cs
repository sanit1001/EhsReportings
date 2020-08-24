using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TlManagement
    {
        public int Tlid { get; set; }
        public string Service { get; set; }
        public string CountryCode { get; set; }
        public string RegionCode { get; set; }
        public string TargetLanguage { get; set; }
        public DateTime? OperationDate { get; set; }
        public string Translator { get; set; }
        public string Modifier { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string SavedXmlPath { get; set; }
        public string Client { get; set; }
        public string EnhesaId { get; set; }
        public string Note { get; set; }
        public bool? Validated { get; set; }
        public bool? Corrected { get; set; }
    }
}
