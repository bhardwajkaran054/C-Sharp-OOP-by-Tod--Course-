using Characters.Warriors;
using System;

public class EntryPoint
{
    static void Main()
    {
        Warrior firstWarrior = new Warrior();
        Warrior secondWarrior = new Warrior(150, 50);
        Warrior thirdWarrior = new Warrior(140, 78, "I am the third warrior!");

        Console.WriteLine(firstWarrior.Name);
        Console.WriteLine(thirdWarrior.Name);
    }
}