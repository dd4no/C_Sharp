using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Employee : IQuittable
    {
        public int ID { get; set; }

        public void Quit()
        {
            Console.WriteLine("Employee #" + ID + " quit");
            Console.Read();
        }
    }
}
