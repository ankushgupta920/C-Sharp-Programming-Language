using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd
{
    internal class EVENODD
    {
        int n;
        public int N { get => n; set => n = value; }

        public string check() 
        {
            if(n%2 == 0)
            {
                return "Number is Even";
            }
            else
            {
                return "Number is Odd";
            }
        }
    }
}
