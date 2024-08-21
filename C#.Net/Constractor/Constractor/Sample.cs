using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constractor
{
    internal class Sample
    {
        private int a, b;

        public Sample(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void display() 
        {
            Console.WriteLine("a={0}\nb={1}",this.a,this.b);
        }   
    }
}
