using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOstream
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            //string number = Console.ReadLine();
            using (StreamWriter number = new StreamWriter(@"C:\Users\daved\Documents\GitHub\C_Sharp\Basic_C#_Programs\IOstream\log.txt", true))
            {
                number.WriteLine(Console.ReadLine());
            }
            string readBack = File.ReadAllText(@"C:\Users\daved\Documents\GitHub\C_Sharp\Basic_C#_Programs\IOstream\log.txt");
            Console.WriteLine("\nYou have entered the number(s):\n" + readBack);
            Console.ReadLine();

        }
    }
}
