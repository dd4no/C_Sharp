using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Overload.DoubleIt(5);
            Console.WriteLine("Doubling 5 gives a value of " + a);
            decimal b = Overload.DoubleIt(5.25m);
            Console.WriteLine("Doubling 5.25 gives a value of " + b);
            string c = Overload.DoubleIt("10");
            Console.WriteLine("Doubling \"10\" gives a value of " + c);

            Console.ReadLine();
        }
    }
}
