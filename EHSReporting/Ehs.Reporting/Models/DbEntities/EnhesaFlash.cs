using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class EnhesaFlash
    {
        public string Email { get; set; }
        public int Idcounter { get; set; }
        public string Organisation { get; set; }
        public int? Idclient { get; set; }
        public string Salutation { get; set; }
        public string LnamePerson { get; set; }
        public string FnamePerson { get; set; }
        public string ContactName { get; set; }
        public string Title { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string TownCity { get; set; }
        public string ProvinceState { get; set; }
        public bool FlashRecipient { get; set; }
        public string Phone { get; set; }
        public string FlashLanguage { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Apuser { get; set; }
        public string Description { get; set; }
        public bool InfoEpcServices { get; set; }
        public string SIndex { get; set; }
        public DateTime InsertDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
