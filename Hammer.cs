using System;
using Toolbox;

public class Hammer : Tool
{
    public Hammer(string name,int weghte) : base(name, weghte)
    {

    }
    public override void Use()
    {
        Console.WriteLine("הפטיש עשוי להכניס ברגים לקיר");
    }
}