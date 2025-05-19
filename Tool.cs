using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
     public class Tool
    {
        string Name;
        int Weghte;
        public Tool(string name,int weghte)
        {
            this.Name = name;
            this.Weghte = weghte;
        }
        public void Descride()
        {
            Console.WriteLine(Name,Weghte);

        }
        public void Use()
        {
            Console.WriteLine("Tool is being used");
        }
    }
}
