using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructor_in_Drived_Class
{
    internal class Sample
    {
        int age, salary;
        public Sample(int a, int b)
        {
            this.age = a; 
            this.salary = b;
        }

        //public Sample()
        //{

        //}
        public void display()
        {
            Console.WriteLine("age={0}\nsalary={1}",age,salary);
        }
    }
}
