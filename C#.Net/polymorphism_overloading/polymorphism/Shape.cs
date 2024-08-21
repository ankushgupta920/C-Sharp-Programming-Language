using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Shape
    {
        // circle
        public double area(float radius)
        {
            return Math.PI * radius * radius;
        }

        //rec
        public int area(int l , int b)
        {
            return l * b;
        }
    }
}
