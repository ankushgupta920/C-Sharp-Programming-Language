using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructor_in_Drived_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample3 obj = new Sample3(3,2,"ankush","MCA");
            obj.display();
            
            Console.ReadLine();
        }
    }
}
