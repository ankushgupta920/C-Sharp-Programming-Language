#define key1
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Attributes
{
    class Test
    {
        //Obsolete Attributes:
        //[Obsolete("This method is outdated, Kindly call (add)method instead of (sum)method",true)]

        //Conditional Attribute:-
        [ConditionalAttribute("key1")]
        public void sum(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(int a , int b)
        {
            Console.WriteLine("The first value is: " + a);
            Console.WriteLine("The secound value is: " + b);
            Console.WriteLine("The Total is:  " + (a + b));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test obj  = new Test();
            obj.sum(10,20);
            obj.add(10,20);

            Console.ReadKey();
        }
    }
}
