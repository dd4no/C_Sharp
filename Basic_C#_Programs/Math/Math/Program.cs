using System;


namespace Math
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            string x = Console.ReadLine();
            int product = Convert.ToInt32(x) * 50;
            Console.WriteLine(x + " times 50 = " + product.ToString());
            Console.WriteLine();

            Console.WriteLine("Please enter a number:");
            string y = Console.ReadLine();
            int sum = Convert.ToInt32(y) + 25;
            Console.WriteLine(y + " plus 25 = " + sum.ToString());
            Console.WriteLine();

            Console.WriteLine("Please enter a number with a decimal point:");
            string z = Console.ReadLine();
            double quotient = Convert.ToDouble(z) / 12.5;
            Console.WriteLine(z + " divided by 12.5 = " + quotient.ToString());
            Console.WriteLine();

            Console.WriteLine("Please enter a number:");
            string a = Console.ReadLine();
            bool compare = Convert.ToInt32(a) > 50;
            Console.WriteLine(a + " is greater than 50? " + compare.ToString());
            Console.WriteLine();

            Console.WriteLine("Please enter a number:");
            string b = Console.ReadLine();
            int remainder = Convert.ToInt32(b) % 7;
            Console.WriteLine(b + " divided by 7 leaves a remainder of: " + remainder.ToString());

            Console.Read();
        }
    }
}
