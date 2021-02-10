using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        struct Number
        {
            public decimal Amount { get; set; }
        }

        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 44.625m;
            Console.WriteLine(number.Amount);
            Console.Read();
        }
    }
}
