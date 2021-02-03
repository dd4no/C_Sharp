using System;


namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            Console.WriteLine("Package Information:");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            Console.WriteLine("Weight in pounds?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Unfortunately, this package is too heavy to be shipped by us.\nThank you for choosing Package Express.\nHave a good day.");
            }
            else
            {
                Console.WriteLine("Width in inches?");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Height in inches?");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Length in inches?");
                decimal length = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();

                decimal dimensions = width + height + length;
                if (dimensions > 50)
                {
                    Console.WriteLine("Unfortunately this package is to large to be shipped by us.\nThank you for choosing Package Express.\nHave a good day.");
                }
                else
                {
                    decimal quote = (width * height * length) / 100;
                    //decimal quote = Convert.ToDecimal(costBase);
                    Console.WriteLine("===============================");
                    Console.WriteLine("Your estimated total shipping cost:");
                    Console.WriteLine("$" + quote.ToString());
                    Console.WriteLine();
                    Console.WriteLine("Thank you for choosing Package Express.\nHave a good day.");
                }
            }
            Console.Read();
        }
    }
}
