using Characters;
using Enumerations;
using Interfaces;
using System;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior : Melee, ICalculator
    {
        private const int DEFAULT_HEIGHT = 170;
        private const int DEFAULT_WEIGHT = 70;
        private const int DEFAULT_AGE = 18;
        private const string DEFAULT_NAME = "Young Warrior";

        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();
        private readonly int id;

        private static int idCounter;

        public static int IdCounter
        {
            get
            {
                return idCounter;
            }
            private set
            {
                idCounter = value;
            }
        }
        
        private int height;
        private Faction faction;
        private Sword swordWeapon;

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
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            private set
            {
                this.faction = value;
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
        
        public Warrior()
            : this(DEFAULT_HEIGHT, DEFAULT_WEIGHT)
        {
        }

        public Warrior(int height, int weight)
            : this(height, weight, DEFAULT_NAME, Faction.Default)
        {
        }

        public Warrior(int height, int weight, string name, Faction faction)
        {
            IdCounter++;

            this.id = IdCounter;
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Faction = faction;
            this.Age = DEFAULT_AGE;
            this.SwordWeapon = DEFAULT_SWORD_WEAPON;

            if (this.Faction == Faction.GoodGuy)
            {
                this.HealthPoints = 120;
            }
            else if (this.Faction == Faction.BadGuy)
            {
                this.HealthPoints = 100;
            }
        }

        public Warrior(int healthPoints, int weight, int age, int height)
            : base(healthPoints, weight, age)
        {
            this.Height = height;
        }
        
        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine($"Default Height: {DEFAULT_HEIGHT}" +
                $"\nDefault Weight: {DEFAULT_WEIGHT}" +
                $"\nDefualt Name: {DEFAULT_NAME}" +
                $"\nDefault Age: {DEFAULT_AGE}" +
                $"\nDefault Weapon Damage: {warrior.DEFAULT_SWORD_WEAPON.Damage}");
        }

        public override string Move(int pauseBetweenMovements)
        {
            return string.Format("I just moved 10 times, I am a Warrior");
            
        }

        public override int Addition(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}