using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryInfo_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\Ankush Gupta\\OneDrive\\Desktop\\C#.Net\\My Directory";
            string path2 = @"C:\\Users\\Ankush Gupta\\OneDrive\\Desktop\\C#.Net\\My Directory 2";
            DirectoryInfo obj = new DirectoryInfo(path2);
            //obj.Delete(true);
            //Console.WriteLine("Directory Deleted");
            //obj.Create();
            //obj.CreateSubdirectory("Another Directory");
            //obj.MoveTo(path2);
            //Console.WriteLine("Directory Moved");
            //Console.WriteLine("Directory Created");
            Console.ReadKey();  
        }
    }
}
