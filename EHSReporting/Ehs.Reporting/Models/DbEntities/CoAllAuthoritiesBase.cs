using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class CoAllAuthoritiesBase
    {
        public int AuthorityId { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Num { get; set; }
        public string ZipCode { get; set; }
        public bool? Archived { get; set; }
        public string Hyperlink { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Fax { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
