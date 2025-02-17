﻿namespace DatabaseManager.Model
{
    public partial class Imagedatum
    {
        public long ImageId { get; set; }
        public string ImageName { get; set; } = null!;
        public byte[] ImageData { get; set; } = null!;
        public byte[] ImageThumbnail { get; set; } = null!;
        public string DefaultFlag { get; set; } = null!;
        public string ImagePurpose { get; set; } = null!;
        public string? ImageDescription { get; set; }
        public string? ImageExtension { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
