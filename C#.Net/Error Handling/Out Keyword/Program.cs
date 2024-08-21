using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Keyword
{
    class Sample
    {
        public void area(int x, int y , out int c)
        {
            c = x * y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            int a;
            obj.area(10, 20, out a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
