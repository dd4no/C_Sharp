using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week:");
                string currentDay = Console.ReadLine();
                Console.WriteLine();
                daysOfWeek day = (daysOfWeek)Enum.Parse(typeof(daysOfWeek), currentDay);
                Console.WriteLine("Today is " + day);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week, or check spelling.");
                Console.ReadLine();
            }
          
        }

        enum daysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
