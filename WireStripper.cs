using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class WireStripper : Tool
    {
        public WireStripper (string name,int weghet) : base(name, weghet)
        {

        }
        public override void Use()
        {
            Console.WriteLine("אני לא יודע מה ");
        }
    }
}
