﻿using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Wbsmemo
    {
        public long WbsMemoId { get; set; }
        public long? ProjId { get; set; }
        public long? MemoTypeId { get; set; }
        public long? WbsId { get; set; }
        public byte[]? WbsMemo1 { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
