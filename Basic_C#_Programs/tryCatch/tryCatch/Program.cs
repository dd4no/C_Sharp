using System;
using System.Collections.Generic;


namespace tryCatch
{
    class Program
    {
        static void Main()
        {
            List<int> dividends = new List<int> { 2, 4, 8, 16, 32, 64, 128, 256 };

            try
            {   
                Console.WriteLine("Select a whole number to divide each number in the list by:");
                int devisor = Convert.ToInt32(Console.ReadLine());
                int quotient;
                Console.WriteLine();

                foreach (int dividend in dividends)
                {
                    quotient = dividend / devisor;
                    Console.WriteLine(quotient);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("The program has continued...");
                Console.ReadLine();
            }
        }
    }
}
