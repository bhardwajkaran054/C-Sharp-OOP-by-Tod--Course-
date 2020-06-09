using Enumerations;
using System;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior
    {
        private const int DEFAULT_HEIGHT = 170;
        private const int DEFAULT_WEIGHT = 70;
        private const int DEFAULT_AGE = 18;
        private const string DEFAULT_NAME = "Young Warrior";

        private readonly int id;
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();

        private static int idCounter;

        public static int IdCounter
        {
            get
            {
                return idCounter;
            }
            set
            {
                idCounter = value;
            }
        }
        
        private int height;
        private int weight;
        private int age;
        private int healthPoints;
        private string name;
        private Sword swordWeapon;
        private Faction faction;

        public int ID
        {
            get
            {
                return this.id;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The selected age for {Name}, is not a proper age for a Warrior. Please use age between 18 and 45.");
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            private set
            {
                this.healthPoints = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Sword SwordWeapon
        {
            get
            {
                return this.swordWeapon;
            }
            set
            {
                this.swordWeapon = value;
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = Faction;
            }
        }


        public Warrior()
            : this(170, 70)
        {
        }

        public Warrior(int height, int weight)
            : this(height, weight, "Young Warrior", Faction.Default)
        {
        }

        public Warrior(int height, int weight, string name, Faction faction)
        {
            IdCounter++;

            this.id = IdCounter;
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = 18;
            this.SwordWeapon = new Sword();
            this.Faction = faction;

            if (this.faction == Faction.GoodGuy)
            {
                this.HealthPoints = 120;
            }
            else if (this.faction == Faction.BadGuy)
            {
                this.HealthPoints = 100;
            }
        }

        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($"Greetings {warrior.Name}!");
        }

        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine($"\nDefault Height: {DEFAULT_HEIGHT}" +
                $"\nDefault Weight: {DEFAULT_WEIGHT}" +
                $"\nDefault Name: {DEFAULT_NAME}" +
                $"\nDefault Age: {DEFAULT_AGE}" +
                $"\nDefault Weapon Damage: {warrior.DEFAULT_SWORD_WEAPON.Damage}");
        }
    }
}