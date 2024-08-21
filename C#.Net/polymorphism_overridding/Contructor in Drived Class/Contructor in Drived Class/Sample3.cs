using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructor_in_Drived_Class
{
    internal class Sample3:Sample2
    {
        string education;
        public Sample3(int a, int b, string name,string education):base(a,b,name)
        {
            this.education = education;
        }

        public void display()
        {
            base.display();
            Console.WriteLine("Education={0}",education);
        }
    }
}
