using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Overload
    {
        public static int MathOp(int x)
        {
            return x * 2;
        }

        public static int MathOp(decimal x)
        {
            int y = Convert.ToInt32(x);
            return y * 3;
        }

        public static int MathOp(string x)
        {
            int y = Convert.ToInt32(x);
            return y / 2;
        }
    }
}
