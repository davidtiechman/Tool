using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Saw :Tool
    {
        public Saw(string name,int weghte) : base(name, weghte)
        {

        }
        public override void Use()
        {
            Console.WriteLine("המסור חותך עץ");
        }
    }
}
