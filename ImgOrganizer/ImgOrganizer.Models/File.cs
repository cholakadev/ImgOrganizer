using System;

namespace ImgOrganizer.Models
{
    public class File
    {
        public DateTime CreationTime { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Directory { get; set; }
    }
}
