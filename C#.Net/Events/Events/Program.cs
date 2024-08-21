using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //its a notification machanism that depends on delegates
    //events is like a wrapper over the delegates to improve its security.

    public delegate int MyDelegate(int a ,  int b);
    class Sample  //Subscriber
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
    internal class Program  //publisher
    {
        static event MyDelegate click;  // event creation:
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            MyDelegate myDelegate_obj = new MyDelegate(obj.add);

            // After creating event we have to connect the event to the class.
            // and connect with our delegate object.
            Program.click += myDelegate_obj;

            int x = Program.click(10, 20);
            Console.WriteLine(x);


            Console.ReadKey();
        }
    }
}
