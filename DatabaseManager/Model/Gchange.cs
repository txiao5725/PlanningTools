﻿namespace DatabaseManager.Model
{
    public partial class Gchange
    {
        public long GchangeId { get; set; }
        public long? UserId { get; set; }
        public string? GchangeName { get; set; }
        public string? TableName { get; set; }
        public byte[]? GchangeData { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
