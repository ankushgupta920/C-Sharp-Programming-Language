using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_overridding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample2 obj = new Sample2();
            Console.WriteLine(obj.add(2,6));

            Console.ReadKey();
        }
    }
}
