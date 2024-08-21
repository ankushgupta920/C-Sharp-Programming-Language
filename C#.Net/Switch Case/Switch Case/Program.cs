using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = System.Console;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice, n1, n2;
            A.WriteLine("1.Add\n");
            A.WriteLine("2.Sub\n");
            A.WriteLine("3.Mul\n");
            A.WriteLine("4.Exit\n");
            A.WriteLine("Enter your choice--> ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    A.WriteLine("Enter n1: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    A.WriteLine("Enter n2: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    A.WriteLine("Sum=" + (n1 + n2));
                    break;

                case 2:
                    A.WriteLine("Enter n1: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    A.WriteLine("Enter n2: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    A.WriteLine("Minus=" + (n1 - n2));
                    break;

                case 3:
                    A.WriteLine("Enter n1: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    A.WriteLine("Enter n2: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    A.WriteLine("Mul=" + (n1 * n2));
                    break;

                case 4:
                    A.WriteLine("Exit successfully..!");
                    break;

                default:
                    break;

            }
            A.ReadLine();
        }
    }          
        
}
