using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hash_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable obj = new Hashtable()
            {
                {"id",1123},
                {"name", "Ankush"}
            };

            foreach(object o in obj.Keys)
            {
                Console.WriteLine(o + ":" + obj[o]);
            }
            //obj.Add("id",1123);
            //obj.Add("name", "Ankush");
            //obj.Add("salary", 25000);
            //obj.Add("designation", "manager");
            //obj.Add("IsMarried", false);

            //Console.WriteLine(obj["id"]);
            Console.ReadLine(); 

        }
    }
}
