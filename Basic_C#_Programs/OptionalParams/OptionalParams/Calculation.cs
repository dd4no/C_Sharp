using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParams
{
    public class Calculation
    {
        public static int DoSomeMath(int numOne, int numTwo = 5)
        {  

            return numOne + numTwo;
        }
          
    }
}
