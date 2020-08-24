using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ErrorHandling
    {
        public int PkErrorHandlingId { get; set; }
        public string ErrorTransactionId { get; set; }
        public int ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public short ErrorSeverity { get; set; }
        public short ErrorState { get; set; }
        public string ErrorProcedure { get; set; }
        public int ErrorLine { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
