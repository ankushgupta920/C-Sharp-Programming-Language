using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK_AND_HEAP
{
    //struct Employee       //Value Type
    //{
    //    public int Salary;
    //    public int Age;
    //}
    class Employee        //Reference Type
    {
        public int Salary;
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.Salary = 5000;
            obj.Age = 23;

            Employee obj1 = obj;
            Employee obj2 = obj;

            obj.Age = 25;
            Console.WriteLine(obj.Age);
            Console.WriteLine(obj1.Age);
            Console.WriteLine(obj2.Age);


            Console.ReadKey();

        }
        
    }
}
