using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class NailGun : Tool
    {
        public NailGun(string name, int weghte) : base(name, weghte)
        {

        }
        
        public override void Use()
        {
            Console.WriteLine("המהדק סיכות מכניס סיכות לקיר");
        }
    }
}
