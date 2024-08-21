using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        public void Show() // Declaring a method  //non-static method
        {
            Console.WriteLine("Welcome to C# Programming....");
            Console.WriteLine("Hey Bro Wassup..");
        }

        public static void Show1() // Declaring a method // static method
        {
            Console.WriteLine("Welcome to C# Programming....");
            Console.WriteLine("Hey Bro Wassup..");
        }
        public static void Sum(int x , int y ) // parameterized method
        {
            int result = x + y;
            Console.WriteLine("Sum: - " + result);
        }   
        static void Main(string[] args)
        {
            //Program obj = new Program();
            //obj.Show();
            //Program.Show1();
            Program.Sum(10, 10);
            Console.ReadKey();
        }
    }
}
