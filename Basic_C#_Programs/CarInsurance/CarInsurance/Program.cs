using System;


namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("INSURANCE QUALIFIER");
            Console.WriteLine("...................");
            Console.WriteLine();

            Console.WriteLine("Please answer the following questions to check your eligibility:");
            Console.WriteLine();

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int Age = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? (Please answer with \"true\" or \"false\")");
            string dui = Console.ReadLine();
            bool DUI = Convert.ToBoolean(dui);

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int Tickets = Convert.ToInt32(tickets);

            bool qualified = (Age > 15 && DUI == false && Tickets <= 3);

            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.WriteLine("Qualified for insurance?");
            Console.WriteLine(qualified);
            Console.Read();

        }
    }
}
