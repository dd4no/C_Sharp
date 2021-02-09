using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> things = new Employee<string>();
            things.Things = new List<string>();
            things.Things.Add("Badge");
            things.Things.Add("Laptop");
            things.Things.Add("Desk");

            Employee<int> numbers = new Employee<int>();
            numbers.Things = new List<int>();
            numbers.Things.Add(666);
            numbers.Things.Add(2);
            numbers.Things.Add(44);

            Console.WriteLine("Employee's Items:");
            foreach (string thing in things.Things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine();

            Console.WriteLine("Employee's Numbers:");
            foreach (int number in numbers.Things)
            {
                Console.WriteLine(number);
            }
            Console.Read();
          
        }
    }
}
