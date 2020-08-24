﻿using System;

namespace Ehs.Reporting.MR.Models
{
    public partial class HistoryIntroText
    {
        public int IntroId { get; set; }
        public string LanguageCode { get; set; }
        public string Intro { get; set; }
        public string BackgroundInfo { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? ValidityDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? QcedDate { get; set; }
        public DateTime? ProofedDate { get; set; }
        public string QcedBy { get; set; }
        public string ProofedBy { get; set; }
        public byte? Status { get; set; }
        public Guid RowId { get; set; }
        public string Md5 { get; set; }
    }
}
