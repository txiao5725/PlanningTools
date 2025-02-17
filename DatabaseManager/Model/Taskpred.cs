﻿namespace DatabaseManager.Model
{
    public partial class Taskpred
    {
        public long TaskPredId { get; set; }
        public long? TaskId { get; set; }
        public long? PredTaskId { get; set; }
        public long? ProjId { get; set; }
        public long? PredProjId { get; set; }
        public string? PredType { get; set; }
        public double? LagHrCnt { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? Comments { get; set; }
    }
}
