using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArgs
{
    class MathOps
    {
        public static void DoSomeStuff(int number1, int number2)
        {
            number1++;
            Console.WriteLine("The second argument is {0}", number2);
        }
    }
}
