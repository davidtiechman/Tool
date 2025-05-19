
using System;
using Toolbox;

public class Wrench : Tool
{
    public Wrench(string name, int weghte) : base(name, weghte)
    {

    }
    
        public override void Use()
    {
        Console.WriteLine("המברג עשוי להוציא ולהכניס ברגים");
    }
    
}