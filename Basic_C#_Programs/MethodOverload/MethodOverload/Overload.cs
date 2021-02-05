using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Overload
    {
        public static int DoubleIt(int x)
        {
            return x * 2;
        }

        public static decimal DoubleIt(decimal x)
        {
            return x * 2;
        }

        public static string DoubleIt(string x)
        {
            int y = Convert.ToInt32(x);
            y = y + y;
            return y.ToString();
        }
    }
}
