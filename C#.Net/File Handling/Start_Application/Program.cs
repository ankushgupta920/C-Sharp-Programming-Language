using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Start_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Menu: ");
            Console.WriteLine("1.Notepad ");
            Console.WriteLine("2.Calc");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter Your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Process.Start("notepad");
                    break;
                case 2:
                    Process.Start("calc");
                    break;
                case 3:
                    Process.Start("exit");
                    break;
                default:
                    Console.WriteLine("Invalid Choice...");
                    break;
            }
        }
    }
}
