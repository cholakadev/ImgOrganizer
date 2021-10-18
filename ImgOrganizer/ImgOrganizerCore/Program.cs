using ImgOrganizer.Models;
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
            DirectoryInfo di = new DirectoryInfo(targetDir);

            foreach (var fl in di.EnumerateFiles())
            {
                var year = fl.CreationTimeUtc.Year;
                var month = fl.CreationTimeUtc.Month;
                var creationDate = new DateTime(year, month, 1);

                // For each file create folder with the created year as name and the created month in the year folder.
                var directoryPathsByYearAndMonths = creationDate.ToString("yyyy/MM");

                di.CreateSubdirectory(directoryPathsByYearAndMonths);
            }



        }
    }
}
