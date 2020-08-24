using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class ClMrCommentText
    {
        public int Idclient { get; set; }
        public int Idtopic { get; set; }
        public string Comment { get; set; }
        public string Biranking { get; set; }
        public DateTime LastUpdated { get; set; }
        public Guid RowId { get; set; }
    }
}
