using System;
using System.Collections.Generic;


namespace ListsAndArrays
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Joey", "Johnny", "Tommy", "DeeDee" };
            Console.WriteLine("Choose and index between 0 and 3");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i < 0 || i > 3)
            {
                Console.WriteLine("You did not follow the directions. Moving on...");
            }
            else
            {
                Console.WriteLine("You picked " + names[i]);
            }
            Console.WriteLine();

            int[] nums = { 37, 22, 69, 45, 90, 2 };
            Console.WriteLine("Choose and index between 0 and 5");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0 || n > 5)
            {
                Console.WriteLine("You did not follow the directions. Moving on...");
            }
            else
            {
                Console.WriteLine("You picked " + nums[n]);
            }
            Console.WriteLine();

            List<string> newNames = new List<string>();
            newNames.Add("Jerry");
            newNames.Add("Bobby");
            newNames.Add("Phil");
            newNames.Add("Billy");
            newNames.Add("Mickey");
            newNames.Add("Brent");

            Console.WriteLine("Choose an index between 0 and 5");
            int j = Convert.ToInt32(Console.ReadLine());
            if (j < 0 || j > 5)
            {
                Console.WriteLine("You did not follow the directions. Goodbye.");
            }
            else
            {
                Console.WriteLine("You picked " + newNames[j]);
            }
            
            Console.Read();


        }
    }
}
