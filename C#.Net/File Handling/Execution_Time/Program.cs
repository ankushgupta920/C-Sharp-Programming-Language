using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Execution_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int i;
            for (i = 1; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
            sw.Stop();
            Console.WriteLine();
            Console.WriteLine("Time Taken: - " + sw.ElapsedMilliseconds);
            Console.ReadLine();



            //var watch  = new System.Diagnostics.Stopwatch();
            //watch.Start();
            //int i;
            //for (i = 1; i <= 1000; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //watch.Stop();
            //Console.WriteLine();
            //Console.WriteLine("Time Taken: - " + watch.ElapsedMilliseconds);
            //Console.ReadLine();
        }
    }
}
