using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting
{
    internal class Program
    {
        class Parent
        {
            public void show()
            {
                Console.WriteLine("Parent class show method ");
            }
        } 
        class Child:Parent
        {
            public void show()
            {
                Console.WriteLine("Child class show method ");
            }
        }
        static void Main(string[] args)
        {
            // Upcasitng
            Parent obj = new Child();
            //obj.show();

            // Downcasting
            Child obj2 = (Child) obj;
            obj2.show();
             

            Console.ReadLine();
        }
    }
}
