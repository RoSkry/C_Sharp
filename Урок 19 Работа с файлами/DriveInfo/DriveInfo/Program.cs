using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveInfo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DriveInfo di = new DriveInfo(@"D:/");
            Console.WriteLine(di.DriveType);
            Console.WriteLine(di.AvailableFreeSpace);
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo d in drives)
            {
                Console.WriteLine(d.Name);
                Console.WriteLine(d.DriveType);
                Console.WriteLine(d.AvailableFreeSpace);
            
        }
    }
    }
}
