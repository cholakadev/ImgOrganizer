using System;
using System.Collections.Generic;
using System.IO;

namespace ImgOrganizerCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
            var targetDir = dirs.Find(x => x.Contains("Test"));
            DirectoryInfo directoryInfo = new DirectoryInfo(targetDir);

            var files = directoryInfo.EnumerateFiles();

            foreach (var file in directoryInfo.EnumerateFiles())
            {
                Console.WriteLine(file.FullName);
                var creationTime = file.CreationTimeUtc;
                Console.WriteLine(creationTime);
            }

        }
    }
}
