using Characters.Warriors;
using CSharpOOP;
using Enumerations;
using System;

public class EntryPoint
{
    static void Main()
    {
        Warrior firstWarrior = new Warrior();
        Warrior secondWarrior = new Warrior(150, 50);
        Warrior thirdWarrior = new Warrior(140, 78, "I am the third warrior!", Faction.GoodGuy);

        Tools.ColorfulWriteLine(secondWarrior.ID.ToString(), ConsoleColor.DarkRed);
        Tools.ColorfulWriteLine(firstWarrior.ID.ToString(), ConsoleColor.DarkYellow);
        Tools.ColorfulWriteLine(thirdWarrior.ID.ToString(), ConsoleColor.Green);

        Warrior.GetDefaultValues(firstWarrior);
    }
}