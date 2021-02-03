using System;


namespace IncomeCompare
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("--------");
            Console.WriteLine();
            Console.WriteLine("Hourly rate?");
            string person1rate = Console.ReadLine();
            Console.WriteLine("Hours per week?");
            string person1hours = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("--------");
            Console.WriteLine();
            Console.WriteLine("Hourly rate?");
            string person2rate = Console.ReadLine();
            Console.WriteLine("Hours per week?");
            string person2hours = Console.ReadLine();
            Console.WriteLine();

            int salary1 = ((Convert.ToInt32(person1rate) * Convert.ToInt32(person1hours)) * 52);
            int salary2 = ((Convert.ToInt32(person2rate) * Convert.ToInt32(person2hours)) * 52);
            bool compare = salary1 > salary2;

            Console.WriteLine("================================");
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine("$" + salary1);
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine("$" + salary2);
            Console.WriteLine();

            Console.WriteLine("Person 1 earns more than Person 2? ");
            Console.WriteLine(compare);
            Console.Read();

        }
    }
}
