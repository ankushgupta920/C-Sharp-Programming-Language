using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Enployee
    {
        private string name;
        public string Name { get => name; set => name = value; }
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public float Marks { get => marks; set => marks = value; }

        float marks;

        public void displayInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Marks : " + marks);
        }

  
    }
}
