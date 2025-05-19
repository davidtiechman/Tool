using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Drill : Tool
    {
        public Drill(string name, int weghte) : base(name, weghte)
        {

        }
        public override void Use()
        {
            Console.WriteLine("הקודח עושה חורים בקיר");
        }
    }
}
