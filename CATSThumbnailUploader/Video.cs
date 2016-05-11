using System;
using Google.Apis.YouTube.v3.Data;

namespace CATSThumbnailUploader
{
    public class Video
    {
        public Thumbnail thumbnail { get; set; }
        public String name { get; set; }
        public String id { get; set; }
    }
}
