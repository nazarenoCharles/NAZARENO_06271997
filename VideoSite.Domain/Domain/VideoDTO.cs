using System.Collections.Generic;
using System;

namespace VideoUpload.Domain
{
    public class VideoDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public string ThumbnailPath { get; set; } = null!;
        public List<string> Categories { get; set; } = new();
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    }
}
