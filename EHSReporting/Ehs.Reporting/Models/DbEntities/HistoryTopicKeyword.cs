using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryTopicKeyword
    {
        public int Idtopic { get; set; }
        public int IdkeyWord { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
