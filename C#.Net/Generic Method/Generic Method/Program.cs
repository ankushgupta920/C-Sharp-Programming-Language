using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method
{
    class Example
    {
        public static void Showarr<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //public static void Showname(string[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2];
            arr[0] = 1;
            arr[1] = 2;

            string[] arr2 = new string[2];
            arr2[0] = "Ankush";
            arr2[1] = "Rajat";
            Example.Showarr(arr);
            Example.Showarr(arr2);
            //Example.Showname(arr2);
            Console.ReadKey();
        }
    }
}
