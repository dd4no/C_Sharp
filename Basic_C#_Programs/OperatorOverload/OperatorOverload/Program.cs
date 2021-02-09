using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { ID = 666 };
            Employee employee2 = new Employee() { ID = 666 };

            if (employee1 == employee2)
            {
                Console.WriteLine("Employee ID's match");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee ID's do not match");
                Console.ReadLine();
            }
        }
    }
}
