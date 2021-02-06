using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            new MathOps();

            MathOps.DoSomeStuff( 5, 15 );

            MathOps.DoSomeStuff(number2: 100, number1: 20);

            Console.Read();
        }
    }
}
