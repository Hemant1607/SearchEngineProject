using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace SearchEngineCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Level1.SearchActiveInactiveDrives();
            // Level1.DisplayAllDrives();

            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            Console.WriteLine("Enter the file to be searched: ");
            string filename = Console.ReadLine();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                DirectoryInfo directoryInfo = item.RootDirectory;
                //Console.WriteLine(directoryInfo);
                Thread level2 = new Thread(() => Level2.SearchFile(directoryInfo, filename));
                level2.Start();
                Thread level3 = new Thread(() => Level3.ParallelSearch(directoryInfo, filename));
                level3.Start();
                //Level3.ParallelSearch(directoryInfo, filename);
                
                //bool IsFound= Level2.SearchFile(directoryInfo, filename);
                //if (IsFound)
                //{
                //    Console.WriteLine("File is found");
                //}
                //else
                //    Console.WriteLine("File is not found");

            }
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");



            Console.ReadLine();
        }
    }
}
