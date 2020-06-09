using Characters;
using Characters.Spellcasters;
using Characters.Warriors;
using Enumerations;
using Interfaces;
using System;
using System.Collections.Generic;

public class EntryPoint
{
    static void Main()
    {
        Warrior firstWarrior = new Warrior(150, 50, "SomeName", Faction.BadGuy);
        Mage firstMage = new Mage();

        Console.WriteLine(firstWarrior.Addition(5, 5));
        
        Console.WriteLine(firstWarrior.HealthPoints);
        Console.WriteLine(firstMage.Mana);

        firstMage.CastSpell(firstWarrior);

        Console.WriteLine(firstWarrior.HealthPoints);
        Console.WriteLine(firstMage.Mana);
        
    }
}