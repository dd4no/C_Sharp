using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            

            Console.WriteLine("Enter a number to perform some math on:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int a = Mathclass.AddTen(userNum);
            Console.WriteLine("Your number plus ten = " + a);
            int b = Mathclass.TimesTen(userNum);
            Console.WriteLine("Your number times ten = " + b);
            int c = Mathclass.MinusTen(userNum);
            Console.WriteLine("Your number minus ten = " + c);

            Console.ReadLine();
        }
    }
}
