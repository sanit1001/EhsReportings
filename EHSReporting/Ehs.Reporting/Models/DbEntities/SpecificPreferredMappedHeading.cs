namespace Ehs.Reporting.MR.Models
{
    public partial class SpecificPreferredMappedHeading
    {
        public string HeadingCode { get; set; }
        public int ClientId { get; set; }
        public string EmailAddress { get; set; }
        public string ClientHeadingCode { get; set; }
        public string Parent { get; set; }
    }
}
