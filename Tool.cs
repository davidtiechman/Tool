using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
        abstract public class Tool
    {
        private string Name;
        private int Weghte;
        public Tool(string name,int weghte)
        {
            this.Name = name;
            this.Weghte = weghte;
        }
        public void Descride()
        {
            Console.WriteLine($"the tool {Name} weghte {Weghte}");

        }
        public abstract void Use();
        
        
    }
}
