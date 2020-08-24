using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class DomainName
    {
        public int DomainNameId { get; set; }
        public int Idclient { get; set; }
        public string EmailDomain { get; set; }
        public bool? Approved { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
