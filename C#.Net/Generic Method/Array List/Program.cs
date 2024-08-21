using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
// Non-Generic 
namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            Console.WriteLine(obj.Capacity);
            obj.Add(1);
            obj.Add("Ankush");
            obj.Add(2.88);
            obj.Add('A');

            foreach(object obj1 in obj)
            {
                Console.Write(obj1 + "  ");
            }
            Console.WriteLine();

            obj.Insert(2,25);
            foreach (object obj1 in obj)
            {
                Console.Write(obj1 + " ");
            }
            Console.WriteLine();

            obj.Remove(1);
            foreach (object obj1 in obj)
            {
                Console.Write(obj1 + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
