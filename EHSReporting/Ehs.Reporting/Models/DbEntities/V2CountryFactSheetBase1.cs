using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class V2CountryFactSheetBase1
    {
        public string CfsBcountryCode { get; set; }
        public byte[] CfsBflag { get; set; }
        public byte[] CfsBmap { get; set; }
        public string CfsBpopulation { get; set; }
        public DateTime? CfsBpopulationDate { get; set; }
        public string CfsBcapitalPop { get; set; }
        public DateTime? CfsBcapitalDate { get; set; }
        public DateTime? CfsBmajorCitiesDate { get; set; }
        public DateTime? CfsBlifeExpectancyDate { get; set; }
        public DateTime? CfsBcurrencyDate { get; set; }
        public DateTime? CfsBlabourStructureDate { get; set; }
        public DateTime? CfsBtradePartnersDate { get; set; }
        public DateTime? CfsBaverageIncomeDate { get; set; }
        public DateTime? CfsBprimeMinisterDate { get; set; }
        public DateTime? CfsBaccidentsDate { get; set; }
        public string CfsBinternationalDialingCcode { get; set; }
        public string CfsBaverageAnnualincome { get; set; }
        public string CfsBpublicHolidaysDate { get; set; }
        public string CfsBapproximateExchangeRateToDollar { get; set; }
        public string CfsBprimeMinister { get; set; }
        public string CfsBheadOofState { get; set; }
        public DateTime? CfsLastReviewedDate { get; set; }
        public string CfsLastReviewedBy { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string RowStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte MajorVersion { get; set; }
        public byte MinorVersion { get; set; }
        public byte RevisionNumber { get; set; }
        public string VersionNumber { get; set; }
        public int UpdateTypeId { get; set; }
        public string ChangeNotes { get; set; }
        public string ChangedBy { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
        public DateTime NewStartDate { get; set; }
        public bool? IsContracted { get; set; }
        public bool? IsOfInterest { get; set; }
    }
}
