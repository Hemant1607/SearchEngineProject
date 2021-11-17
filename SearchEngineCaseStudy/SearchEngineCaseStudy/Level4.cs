using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchEngineCaseStudy
{
    
    public class Level4
    {
        public static int check = 0;
        public static void CheckHistory(string filename)
        {
            int found = 0;
            StreamReader reader = new StreamReader(@"C:\training\Skill Assure Training\SearchEngine\SearchEngineProject\SearchEngineCaseStudy\History.txt");
            while (!reader.EndOfStream)
            {
                string path = reader.ReadLine();
                string[] res = path.Split(',');
                if (res[0] == filename)
                {
                    Console.WriteLine(res[1]);
                    found = 1;
                    check = 1;
                    break;
                }

            }
            reader.Close();
            if (found == 0)
            {
                Console.WriteLine("File not in history");
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (var item in drives)
                {
                    DirectoryInfo directoryInfo = item.RootDirectory;
                    //Console.WriteLine(directoryInfo);
                    bool IsFound = Level2.SearchFile(directoryInfo, filename);
                    if (IsFound)
                    {
                        Console.WriteLine("File is found");
                        check = 2;
                    }
                    else
                    {
                        Console.WriteLine("file not found");
                    }

                }
            }

        }
    }
}
