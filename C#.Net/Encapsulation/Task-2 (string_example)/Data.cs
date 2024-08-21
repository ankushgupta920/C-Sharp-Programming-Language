using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_example
{
    internal class Data
    {
        string x;
        public string X { get => x; set => x = value; }

        public void data()
        {
            string[] arr = x.Split(',');
            int i;
            for(i =0 ; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
