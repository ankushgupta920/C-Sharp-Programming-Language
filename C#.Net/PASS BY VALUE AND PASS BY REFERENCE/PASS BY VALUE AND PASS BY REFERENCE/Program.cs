using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASS_BY_VALUE_AND_PASS_BY_REFERENCE
{
    internal class Program
    {

        public static void PassbyValue(int a)  // Pass by Value
        {
            a = a + 10;
            Console.WriteLine("Value is: {0}", a);
        }

        public static void PassbyRef(ref int a)  // Pass by Reference
        {
            a = a + 10;
            Console.WriteLine("Value is: {0}", a);
        }

        public static void PassbyOut(out int a)  // Pass by Out
        {
            a = 20;
            Console.WriteLine("Value is: {0}", a);
        }



        static void Main(string[] args)
        {
            //int value = 5;
            //PassbyRef(ref value);
            //Console.WriteLine(value);

            int value;
            PassbyOut(out value);
            Console.WriteLine(value);


            Console.ReadLine();
        }
    }
}
