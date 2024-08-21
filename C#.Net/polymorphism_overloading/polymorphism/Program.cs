using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Function Overloading:

            Shape obj = new Shape();
            int x = obj.area(10,2);
            Console.WriteLine("Area of Rect:- {0}" , x);


            double y = obj.area(4.5f);
            Console.WriteLine("Area of Circle:- {0}", y);

            Console.ReadKey();
        }
    }
}
