using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extras
{
    class Program
    {
        static void Main()
        {
            const string myName = "My name is Dave Defourneaux, and that's not going to change.";
            Console.WriteLine("Some things are constant...\n" + myName);

            var pi = 3.14;
            Console.WriteLine("\nThis variable was assigned using \"var\":\npi = " + pi + "\n");
                
            new ConstructIt();
            new ConstructIt("truck");
            new ConstructIt("truck", "red");

            Console.Read();
        }
    }
}
