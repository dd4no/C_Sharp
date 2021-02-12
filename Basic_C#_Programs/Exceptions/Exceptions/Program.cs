using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your age:");

            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age == 0 || age < 0)
                {
                    throw new NumberException();
                }
                int yearBorn = DateTime.Now.Year - age;
                Console.WriteLine("You were born in {0}", yearBorn);                
            }
            catch (NumberException)
            {
                Console.WriteLine("Your age can not be zero, or less than zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
            Console.ReadLine();
        }
    }
}
