﻿using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Procitem
    {
        public long ProcItemId { get; set; }
        public long? ProcGroupId { get; set; }
        public long? SeqNum { get; set; }
        public string? ProcName { get; set; }
        public double? ProcWt { get; set; }
        public byte[]? ProcDescr { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
