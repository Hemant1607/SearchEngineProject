using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchEngineCaseStudy
{
    public class Level1
    {
      public static DriveInfo[] list = DriveInfo.GetDrives();
        
        public static bool SearchActiveInactiveDrives()
        {
          
            foreach (DriveInfo d in list)
            {

                if (d.IsReady)
                {
                    Console.WriteLine("Active Drives: " + d.Name);

                }
                else
                {
                    Console.WriteLine("Inactive drive: " + d.Name);
                }

            }
            return true;

        }
        public static bool DisplayAllDrives()
        {
            Console.WriteLine("List of Drives: ");
           
            foreach (DriveInfo d in list)
            {


                Console.WriteLine(d.Name);

            }
            return true;
        }
    }
}
