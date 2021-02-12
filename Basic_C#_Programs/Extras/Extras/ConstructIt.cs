using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extras
{
    class ConstructIt
    {
        public string Name;
        public string Color;

        public ConstructIt() : this("Generic object", "colorless")
        {
        }
        
        public ConstructIt(string name) : this(name, "colorless")
        {
        }

        public ConstructIt(string name, string color)
        {
            Name = name;
            Color = color;
            Console.WriteLine("A {0} {1} was created.", color, name);
        }

    }
}
