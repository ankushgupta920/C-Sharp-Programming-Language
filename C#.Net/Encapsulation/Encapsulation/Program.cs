using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using A = System.Console;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enployee obj = new Enployee();
            obj.Name = "Ankush";
            obj.Age = 20;
            obj.Marks = 99.9f;

            obj.displayInfo();
            Console.ReadKey();  

        }
    }
}
