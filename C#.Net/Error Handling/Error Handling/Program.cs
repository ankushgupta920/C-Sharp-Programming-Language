using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using A = System.Console;

namespace Error_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.WriteLine("Enter the value of A:- ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of B:- ");
                b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("c = {0}", c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("HI");
                Console.WriteLine("hello");
            }
            Console.ReadLine();


        }
    }
}
