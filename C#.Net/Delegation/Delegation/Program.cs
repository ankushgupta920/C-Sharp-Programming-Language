using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    internal class Program
    {
        public delegate void multiply(int a ,  int b);
        public void mul(int a , int b)
        {
            Console.WriteLine("Mul = " + (a * b));
        }
        public void addition(int a , int b)
        {
            Console.WriteLine("Add = " + (a + b)); 
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            multiply del_obj = new multiply(obj.mul);
            del_obj += obj.addition;
            del_obj -= obj.mul;
            del_obj(10, 20);

            Console.ReadLine();
        }
    }
}
