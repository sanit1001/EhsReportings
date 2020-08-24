using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class PkV2MrBusinessImpactBase
    {
        public int Idclient { get; set; }
        public int Idtopic { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
    }
}
