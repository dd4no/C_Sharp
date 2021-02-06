using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main()
        {
            OutputNumbers output = new OutputNumbers();

            Console.WriteLine("Enter a whole number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            output.DivideByTwo(userNumber);           
            Console.WriteLine();
           
            OutputNumbers.OutParameter(out int outExample);
            Console.WriteLine(outExample);
            Console.WriteLine();

            int intNumber = OutputNumbers.Multiply(3, 7);
            Console.WriteLine(intNumber);
            float floatNumber = OutputNumbers.Multiply(2.44f, 6.66f);
            Console.WriteLine(floatNumber);
            Console.WriteLine();

            int staticClassNum = UtilityClass.DoubleIt(12);
            Console.WriteLine(staticClassNum);

            Console.ReadLine();
        }
    }
}
