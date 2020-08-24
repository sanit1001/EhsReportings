using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class TblPurchaseOrders
    {
        public string PoDescription { get; set; }
        public DateTime? PoDate { get; set; }
        public string PoNumber { get; set; }
        public string PoDeliveryAddress { get; set; }
        public DateTime? PoDeliveryDate { get; set; }
        public string PoContactPerson { get; set; }
        public int? PoClientManager { get; set; }
        public string PoPaymentTerms { get; set; }
        public int? PoCustId { get; set; }
        public byte? PoStatus { get; set; }
        public DateTime? PoCreatedDate { get; set; }
        public string PoCreatedBy { get; set; }
        public DateTime? PoChangedDate { get; set; }
        public string PoChangedBy { get; set; }
        public int PoId { get; set; }
        public string PoRef { get; set; }
        public string PoReabilitycomment { get; set; }
        public string PoPrjOwner { get; set; }
        public string PoFullDocumented { get; set; }
        public string PoNote { get; set; }
        public bool? PoClose { get; set; }
        public string PoCloseBy { get; set; }
        public DateTime? PoCloseAt { get; set; }
        public DateTime? PoExpectedAcooplishDate { get; set; }
        public DateTime? PoReminderDate { get; set; }
    }
}
