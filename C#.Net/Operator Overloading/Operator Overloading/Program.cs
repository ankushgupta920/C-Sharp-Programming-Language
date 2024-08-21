using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Sample
    {
        int a, b, c;
        public Sample(int a, int b, int c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public Sample()
        {

        }

        // unary operator:-
        public static Sample operator -(Sample s1)
        {
            Sample s2 = new Sample();
            s2.a = -s1.a;
            s2.b = -s1.b;
            s2.c = -s1.c;
            return s2;
        }

        // unary operator:-
        public static Sample operator ++(Sample s1)
        {
            s1.a = ++s1.a;
            s1.b = ++s1.b;
            s1.c = ++s1.c;
            return s1;
        }

        public void display()
        {
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sample obj = new Sample(10, 20, 40);
            //obj.display();

            //obj = -obj;
            //obj.display();

            //obj = ++obj;
            //obj.display();


            //Binary operator overloading:-
            Sample2 obj1 = new Sample2(12);
            Sample2 obj2 = new Sample2(21);
            Sample2 obj3 = obj1  + obj2;
            obj3.display();

            Console.ReadKey();
        }
    }
}
