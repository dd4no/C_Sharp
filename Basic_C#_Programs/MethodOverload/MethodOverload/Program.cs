using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main()
        {
            int a = Overload.MathOp(5);
            Console.WriteLine("Doubling 5 gives a value of " + a);
            int b = Overload.MathOp(5.25m);
            Console.WriteLine("Trippling 5.25 gives a value of " + b);
            int c = Overload.MathOp("40");
            Console.WriteLine("Halving \"40\" gives a value of " + c);

            Console.ReadLine();
        }
    }
}
