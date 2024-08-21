using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constractor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample(4,5);
            obj.display();
            Console.ReadKey();
        }
    }
}
