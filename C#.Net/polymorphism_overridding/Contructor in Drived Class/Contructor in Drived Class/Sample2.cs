using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructor_in_Drived_Class
{
    internal class Sample2:Sample
    {
        string name;
        public Sample2(int a , int b , string name):base(a,b)
        {
            this.name = name;
        }

        public void display()
        {
            base.display();
            Console.WriteLine("name={0}",name);
        }
    }
}
