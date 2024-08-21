using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SciCal obj = new SciCal();
            Console.WriteLine(obj.sum(2,4));
            Console.WriteLine(obj.mul(2,4));
            Console.WriteLine(obj.square(4));
            Console.WriteLine(obj.cube(4));
            Console.WriteLine(obj.evenodd(4));
            
            Console.ReadKey();
        }
    }
}
