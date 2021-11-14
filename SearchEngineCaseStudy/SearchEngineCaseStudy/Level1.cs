using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SearchEngineCaseStudy
{
    class Level1
    {
      public static DriveInfo[] list = DriveInfo.GetDrives();
        
        public static void SearchActiveInactiveDrives()
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

        }
        public static void DisplayAllDrives()
        {
            Console.WriteLine("List of Drives: ");
           
            foreach (DriveInfo d in list)
            {


                Console.WriteLine(d.Name);

            }
            
        }
    }
}
