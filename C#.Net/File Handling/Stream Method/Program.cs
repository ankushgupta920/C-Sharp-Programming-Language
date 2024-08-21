using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stream_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\Ankush Gupta\OneDrive\Desktop\C#.Net\try.txt";
            //StreamWriter obj = new StreamWriter(path);
            //string name, city;
            //Console.WriteLine("Enter Name: ");
            //name = Console.ReadLine();
            //Console.WriteLine("Enter City: ");
            //city = Console.ReadLine();
            //obj.Write(name + "\n");
            //obj.Write(city + "\n");
            //obj.Close();


            // Write anything acc. to your work.
            //string path = @"C:\Users\Ankush Gupta\OneDrive\Desktop\C#.Net\try.txt";
            //StreamWriter obj = new StreamWriter(path);
            //string name = " ";
            //Console.WriteLine("Enter Data: ");
            //name = Console.ReadLine();    
            //while(name!= "")
            //{
            //    obj.Write(name + "\n");
            //    name = Console.ReadLine();
            //}
            //obj.Close();


            // How to read File:
            //string path = @"C:\Users\Ankush Gupta\OneDrive\Desktop\C#.Net\try.txt";
            //StreamReader obj = new StreamReader(path);
            //obj.BaseStream.Seek(0, SeekOrigin.Begin);
            //string line = obj.ReadLine();
            //while (line!=null)
            //{
            //    Console.WriteLine(line);
            //    line = obj.ReadLine();  

            //}
            //obj.Close();


            // Convert given file into capital letter:
            string path1 = @"C:\Users\Ankush Gupta\OneDrive\Desktop\C#.Net\try.txt";
            string path2 = @"C:\Users\Ankush Gupta\OneDrive\Desktop\C#.Net\try2.txt";
            StreamReader sr = new StreamReader(path1);
            StreamWriter sw = new StreamWriter(path2);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string line = sr.ReadLine();
            while (line != null)
            {
                sw.Write(line.ToUpper() + "\n");
                line = sr.ReadLine();

            }
            sr.Close();
            sw.Close();
            Console.ReadKey();
             
            
        }
    }
}
