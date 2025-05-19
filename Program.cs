using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drill drill1 = new Drill("drill",2);
            Saw saw1 = new Saw("saw", 1);
            Saw saw2 = new Saw("saw", 2);
            Saw saw3 = new Saw("saw", 3);
            Wrench wrench1 = new Wrench("wrench", 5);
            Hammer hammer1 = new Hammer("hammer", 10);
            List<Tool> listTool = new List<Tool>() { drill1, saw1, saw2, saw3, wrench1, hammer1 };

            foreach (Tool tool in listTool)
            {
                tool.Descride();
            }
        }
    }
}
