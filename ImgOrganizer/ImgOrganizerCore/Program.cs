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

            foreach (var file in di.EnumerateFiles())
            {
                var year = file.CreationTimeUtc.Year;
                var month = file.CreationTimeUtc.Month;
                var creationDate = new DateTime(year, month, 1);

                // For each file create folder with the created year as name and the created month in the year folder.
                // Create method for it
                var directoryPathsByYearAndMonths = creationDate.ToString("yyyy/MM");

                if (di.Exists)
                {
                    di.CreateSubdirectory(directoryPathsByYearAndMonths);
                    //File.Move(targetDir, directoryPathsByYearAndMonths);
                    var fileSourcePath = @$"{file.FullName}";
                    var fileDestPath = @$"{targetDir}/{directoryPathsByYearAndMonths}/{file.Name}";
                    File.Move(fileSourcePath, fileDestPath);
                }
            }
        }
    }
}
