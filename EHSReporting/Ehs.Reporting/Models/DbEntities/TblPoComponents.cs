using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TblPoComponents
    {
        public float? PoCoSalesPrice { get; set; }
        public string PoCoCurrency { get; set; }
        public string PoCoFeedBack { get; set; }
        public DateTime? PoCoRequestedDeliveryDate { get; set; }
        public string PoCoInvoiceSchedule { get; set; }
        public string PoCoTailoring { get; set; }
        public int? PoCoPoId { get; set; }
        public int? PoCoDid { get; set; }
        public int PoCoId { get; set; }
        public DateTime? PoCoDeliveryDate { get; set; }
        public string PoCoHeadingSet { get; set; }
        public bool? PoCoInvoiced { get; set; }
        public DateTime? PoDate { get; set; }
        public DateTime? PoLastModifiedDate { get; set; }
        public string PoModifiedBy { get; set; }
    }
}
