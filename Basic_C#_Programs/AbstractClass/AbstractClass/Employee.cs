using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        void IQuittable.Quit()
        {
            throw new NotImplementedException();
        }
    }
}
