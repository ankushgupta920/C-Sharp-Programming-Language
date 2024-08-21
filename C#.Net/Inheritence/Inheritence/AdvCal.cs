using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class AdvCal : Cal
    {
        public double square(int a)
        {
            return a* a;
        }

        public double cube(int a)
        {
            return a * a * a;
        }
    }
}
