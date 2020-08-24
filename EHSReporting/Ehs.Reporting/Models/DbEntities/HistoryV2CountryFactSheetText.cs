using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryV2CountryFactSheetText
    {
        public string CfsTcountryCode { get; set; }
        public string CfsTlanguageCode { get; set; }
        public string CfsTclimate { get; set; }
        public string CfsTcapital { get; set; }
        public string CfsTmajorCities { get; set; }
        public string CfsTareaComparative { get; set; }
        public string CfsTmajorLanguage { get; set; }
        public string CfsTmajorReligion { get; set; }
        public string CfsTinternationalAirports { get; set; }
        public string CfsTpublicHolidays { get; set; }
        public string CfsTmonetaryUnit { get; set; }
        public string CfsTlabourStructure { get; set; }
        public string CfsTmajorTradePartners { get; set; }
        public string CfsTmainIndustries { get; set; }
        public string CfsTmainExports { get; set; }
        public string CfsTcurrentEnvironmentalIssues { get; set; }
        public string CfsTfatalWorkAaccidents { get; set; }
        public string CfsT3daysAbsenceAccidents { get; set; }
        public string CfsTlocation { get; set; }
        public string CfsTlifeexpectancy { get; set; }
        public DateTime? CfsLastModifiedDate { get; set; }
        public string CfsLastModifiedBy { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
