using System;

namespace OptionalParams
{
    class Program
    {
        static void Main()
        {
            int result;

            Console.WriteLine("Choose a number:");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Optionally choose a second number:");

            if (int.TryParse(Console.ReadLine(), out int userNum2))
            {
                result = Calculation.DoSomeMath(userNum1, userNum2);
            }
            else
            {
                Console.WriteLine("The default number is 5");
                result = Calculation.DoSomeMath(userNum1);
            }          

            Console.WriteLine();
            Console.WriteLine("Those two numbers added together = {0}", result);
            Console.ReadLine();
        }
    }
}