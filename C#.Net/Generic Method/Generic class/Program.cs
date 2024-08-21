using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class
{
    class Example<T>
    {
        T box;
        public T Box { get => box; set => box = value; }


        //public Example(T b)
        //{
        //    this.box = b;
        //}
        //public T getBox()
        //{
        //    return this.box;
        //}

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example obj = new Example(20);
            //Console.WriteLine(obj.getBox());

            //Example<string> obj = new Example<string>("Ankush");
            //Console.WriteLine(obj.getBox());

            Example<int> obj = new Example<int>();
            obj.Box = 20;
            Console.WriteLine(obj.Box);
            Console.ReadLine();
        }
    }
}
