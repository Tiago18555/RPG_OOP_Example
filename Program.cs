using System;
using RPG_OOP_example.src.Entities;

namespace RPG_OOP_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 75, 5200, 590);
            Wizard jennica = new Wizard("Jennica", 25, 975, 2100);
            BlackWizard gandalf = new BlackWizard("Gandalf", 95, 3200, 16750);
            Ninja joeMusashi = new Ninja("Joe Musashi", 70, 3500, 1680);

            Console.WriteLine("Status: ");
            Console.WriteLine(arus);
            Console.WriteLine(jennica);
            Console.WriteLine(gandalf);
            Console.WriteLine(joeMusashi);

            Console.WriteLine(@$"
                {arus.agir(250)}
                {jennica.agir(60)}
                {gandalf.agir(3500)}
                {joeMusashi.agir(2000)}                
            ");


        }
    }
}
