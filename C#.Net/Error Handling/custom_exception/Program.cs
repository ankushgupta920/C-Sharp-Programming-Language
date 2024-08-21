using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_exception
{
    class AgeException : Exception
    {
        public AgeException(string msg) : base(msg) { }
        //public AgeException() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the value of age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 18)
                {
                    throw new AgeException("Age less than 18...wrong.");
                }
                else
                {
                    Console.WriteLine("Age is Valid: ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("hii...");
            }

            Console.ReadLine(); 
        }
    }
}
