﻿using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class DecTreeCodeDecTreeCode3
    {
        public string DecTreeCodeChild { get; set; }
        public string DecTreeCodeParent { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
        public DateTime NewResearchDate { get; set; }
        public string RowStatus { get; set; }
        public int UpdateTypeId { get; set; }
        public string ChangeNotes { get; set; }
        public string ChangedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? StartDateDecTreeCodeChild { get; set; }
        public DateTime? StartDateDecTreeCodeParent { get; set; }
        public byte MajorVersion { get; set; }
        public byte MinorVersion { get; set; }
        public byte RevisionNumber { get; set; }
        public string VersionNumber { get; set; }
        public DateTime LastPublishedStartDate { get; set; }
        public DateTime NewStartDate { get; set; }
        public bool? IsContracted { get; set; }
        public bool? IsOfInterest { get; set; }
    }
}
