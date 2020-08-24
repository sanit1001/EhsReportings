namespace Ehs.Reporting.MR.Settings
{
    public class EmailSettings
    {
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public bool ShouldSendEmailToTestUser { get; set; }
        public string TestUserEmail { get; set; }
        public int? DelayPerBatchMiliSeconds { get; set; }
        public int? BulkSize { get; set; }
    }
}
