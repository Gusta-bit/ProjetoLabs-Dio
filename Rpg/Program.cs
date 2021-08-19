using System;
using Rpg.Src.Entities;


namespace Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 23, "Knight");
            Ninja ninja = new Ninja("Wedge", 42, "Ninja");
            Wizard wizard = new Wizard("Jenica", 42, "White Wizard");
            WizardBlack wizardBlack = new WizardBlack("Topapa", 42, " Black Wizard");

            Console.WriteLine(hero);
            Console.WriteLine(ninja);
            Console.WriteLine(wizard);
            Console.WriteLine(wizardBlack);

            Console.WriteLine("----------------------");

            Console.WriteLine(hero.Attack());
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizardBlack.Attack());
        }
    }
}
