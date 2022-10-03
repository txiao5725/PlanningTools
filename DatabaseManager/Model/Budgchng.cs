﻿using System;
using System.Collections.Generic;

namespace DatabaseManager.Model
{
    public partial class Budgchng
    {
        public long BudgChngId { get; set; }
        public long? ProjId { get; set; }
        public long? WbsId { get; set; }
        public string? ChngByName { get; set; }
        public string? ChngShortName { get; set; }
        public byte[]? ChngDate { get; set; }
        public double? ChngCost { get; set; }
        public string? StatusCode { get; set; }
        public string? ChngDescr { get; set; }
        public byte[]? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public byte[]? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public byte[]? DeleteDate { get; set; }
    }
}
