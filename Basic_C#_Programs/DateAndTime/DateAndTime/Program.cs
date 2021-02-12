using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime();
            time = DateTime.Now;

            Console.WriteLine("The current date and time is:");
            Console.WriteLine(time + "\n");

            Console.WriteLine("Please enter hours into the future:");
            double hours = Convert.ToDouble(Console.ReadLine());

            DateTime futureTime = time.AddHours(hours);
            Console.WriteLine("\nIn {0} hours it will be:", hours);
            Console.WriteLine(futureTime);

            Console.ReadLine();
        }
    }
}
