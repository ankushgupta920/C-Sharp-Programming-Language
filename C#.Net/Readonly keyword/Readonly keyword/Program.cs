using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonly_keyword
{
    class Sample
    {
        public readonly int x;       // instance variable
        public Sample(int x)    // local variable
        {
            this.x = x;
        }
        public void displayX()
        {
            Console.WriteLine("x=" + this.x);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample(10);
            //s1.x = 32; // error : bcz we have already created x as readonly 
            s1.displayX();

            Console.ReadKey ();
        }
    }
}
