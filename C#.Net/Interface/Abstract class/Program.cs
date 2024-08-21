using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    abstract class Test
    {
        public abstract void show();
        public void display()
        {
            Console.WriteLine("display");
        }
    }
    class Sample : Test
    {
        public override void show()
        {
            Console.WriteLine("show");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            obj.show();
            obj.display();
            Console.ReadLine();
        }
    }
}
