using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data obj = new Data();
            obj.X = "ram,gurgaon,23,35500,98787887";
            obj.data();

            Console.ReadLine();
        }
    }
}
