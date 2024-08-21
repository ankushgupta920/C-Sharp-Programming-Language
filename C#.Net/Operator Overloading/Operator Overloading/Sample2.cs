using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    internal class Sample2
    {
        int a;
        public Sample2(int a)
        {
            this.a = a;
        }
        public Sample2()
        {

        }

        public static Sample2 operator +(Sample2 obj1 , Sample2 obj2)
        {
            Sample2 obj3 = new Sample2();
            obj3.a = obj1.a + obj2.a;
            return obj3;
        }
        public void display ()
        {
            Console.WriteLine("The value of a: " + this.a);   
        }
    }
}
