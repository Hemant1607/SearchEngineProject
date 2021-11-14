using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace SearchEngineCaseStudy
{
    class Level3
    {
        public static int found = 0;
        public static void ParallelSearch(DirectoryInfo DInfo,string filename)
        {
            FileInfo[] files = null;
            DirectoryInfo[] directories = null;

            try
            {
                files = DInfo.GetFiles();
                //Console.WriteLine("1");
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                Parallel.ForEach(files, file =>
                {
                    if (SearchFile(file, filename))
                    {
                        
                        Console.WriteLine(file.DirectoryName+" Parallel");
                        if (found == 1)
                        {

                        }
                        return;
                    }
                });
            }

            try
            {
                directories = DInfo.GetDirectories();
                //Console.WriteLine("1");
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }
            if (directories != null)
            {
                Parallel.ForEach(directories, directory =>
                {
                    ParallelSearch(directory, filename);
                });
            }
        }

        public static bool SearchFile(FileInfo file, string filename)
        {
            if (file.Name == filename)
            {
                //Console.WriteLine(file.DirectoryName);
                found = 1;
                return true;
            }
                
            else
                return false;
        }
	

	
    }
}
