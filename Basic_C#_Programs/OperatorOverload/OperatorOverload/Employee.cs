using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool match = false;
            if (employee1.ID == employee2.ID)
            {
                match = true;
            }
            return match;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool match = false;
            if (employee1.ID != employee2.ID)
            {
                match = true;
            }
            return match;
        }
    }
}
