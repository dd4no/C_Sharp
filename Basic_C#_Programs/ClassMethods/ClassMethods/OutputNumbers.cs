using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class OutputNumbers
    {
        public void DivideByTwo(int number)
        {
            Console.WriteLine(number / 2);
        }

        public static void OutParameter(out int number)
        {
            number = 18;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
