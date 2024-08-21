using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Checking if a File Exist or Not
            //string path = @"C:\Users\Ankush Gupta\OneDrive\Desktop\C#.Net\data.txt";
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("Yes, There is a File...");
            //}
            //else
            //{
            //    Console.WriteLine("File not found...");
            //}


            //READING DATA FROM TEXT FILE 
            //string path = @"C:\Users\Ankush Gupta\OneDrive\Desktop\C#.Net\data.txt";
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("Yes, There is a File...");
            //    string data = File.ReadAllText(path);
            //    Console.WriteLine(data);
            //}
            //else
            //{
            //    Console.WriteLine("File not found...");
            //}


            //CREATE A COPY OF TEXT FILE 
            string path = @"C:\Users\Ankush Gupta\OneDrive\Desktop\C#.Net\data.txt";
            string path2 = @"C:\Users\Ankush Gupta\OneDrive\Desktop\C#.Net\data2.txt";
            File.Copy(path, path2);
            //File.Copy(path, path2, true);  if the txt file is already exist then it will overwrite the main file.     



            Console.ReadKey();
        }
    }
}
