using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class FacilityDomainName
    {
        public int Idclient { get; set; }
        public string FacilityCode { get; set; }
        public string EmailDomain { get; set; }
        public string UserPermission { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
