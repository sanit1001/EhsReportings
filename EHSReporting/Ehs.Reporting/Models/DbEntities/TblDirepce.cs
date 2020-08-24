using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TblDirepce
    {
        public int Idcounter { get; set; }
        public string Organisation { get; set; }
        public int? Idclient { get; set; }
        public string LnamePerson { get; set; }
        public string FnamePerson { get; set; }
        public string Profession { get; set; }
        public string Sex { get; set; }
        public string SIndex { get; set; }
        public string Intl { get; set; }
        public string Pref1 { get; set; }
        public string Phone1 { get; set; }
        public string Pref2 { get; set; }
        public string Phone2 { get; set; }
        public string Pref3 { get; set; }
        public string Phone3 { get; set; }
        public string Pref4 { get; set; }
        public string Phone4 { get; set; }
        public string PrefF { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Num { get; set; }
        public string ZipCode { get; set; }
        public string TownCity { get; set; }
        public string ProvinceState { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Notes { get; set; }
        public string Hyperlink { get; set; }
        public string Flash { get; set; }
        public string CountryCode { get; set; }
        public bool EnhesaFlash { get; set; }
        public string FlashLanguage { get; set; }
        public string Apuser { get; set; }
        public int? IndustrySector { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public bool InfoEpcServices { get; set; }
        public string UserNotes { get; set; }
        public int? LeadSource { get; set; }
        public string TranslationNotes { get; set; }
        public string EnhesaType { get; set; }
        public string ModifiedBy { get; set; }
        public string BasedIn { get; set; }
        public string OfficeArea { get; set; }
        public DateTime InsertDate { get; set; }
        public bool ClientContactPerson { get; set; }
        public int Webinards { get; set; }
        public int MrreportAlert { get; set; }
        public int MailAlertFrequency { get; set; }
        public int EnhesaServiceUpdate { get; set; }
        public int ServiceUpdateFrequency { get; set; }
        public int Category { get; set; }
        public bool IsClientWebsiteContact { get; set; }
        public string OrganizationDivision { get; set; }
    }
}
