using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchEngineCaseStudy
{
    public class Level2
    {
       
        public static bool SearchFile(DirectoryInfo DInfo, string filename)
        {
            FileInfo[] files = null;


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
                foreach (var item in files)
                {

                    if (item.Name == filename)
                    {
                        Console.WriteLine(item.DirectoryName);
                        return true;
                    }
                }
            }


            return SearchDirectory(DInfo, filename);


        }

        public static bool SearchDirectory(DirectoryInfo DInfo, string filename)
        {
            DirectoryInfo[] directories = null;

            try
            {
                directories = DInfo.GetDirectories();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }

            if (directories != null)
            {
                foreach (var item in directories)
                {
                    
                    if (SearchFile(item, filename))
                    {
                        return true;
                    }
                }

            }
            return false;
        }
    }
}
