using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EVENODD obj = new EVENODD();
            obj.N = 12;
            Console.WriteLine(obj.check());

            Console.ReadLine();
        }
    }
}
