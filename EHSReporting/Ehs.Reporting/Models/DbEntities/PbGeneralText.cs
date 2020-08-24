using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PbGeneralText
    {
        public int Pk { get; set; }
        public string ResourceId { get; set; }
        public string Value { get; set; }
        public string LocaleId { get; set; }
        public string ResourceSet { get; set; }
        public string Type { get; set; }
        public byte[] BinFile { get; set; }
        public string TextFile { get; set; }
        public string Filename { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
