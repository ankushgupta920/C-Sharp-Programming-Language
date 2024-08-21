using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    // It provide the sturuture: 
    interface A
    {
        int sum(int a, int b);
    }
    interface B
    {
        int mul(int a, int b);
    }

    class Test:A,B
    {
        public int sum(int a, int b)
        {
            return a + b;
        }

        public int mul(int a, int b)
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test obj = new Test();
            //int x = obj.mul(1, 2);
            //int y = obj.sum(3, 2);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            A obj1 = new Test();   //up
            int x = obj1.sum(2, 3);
            Console.WriteLine(x);

            B obj2 = (B)obj1;
            int y = obj2.mul(2, 3);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
