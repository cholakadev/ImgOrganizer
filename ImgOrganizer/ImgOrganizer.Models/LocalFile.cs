using System;

namespace ImgOrganizer.Models
{
    public class LocalFile
    {
        public DateTime CreationTimeUtc { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Directory { get; set; }
    }
}
