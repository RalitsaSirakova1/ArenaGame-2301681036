using System;

namespace ArenaGame
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Durability { get; set; }
        public string Speed { get; set; }
        public int Accuracy { get; set; }
        public string Special { get; set; }

        public Weapon() { }

        public Weapon(string name, int durability, string speed, int accuracy, string special)
        {
            Name = name;
            Durability = durability;
            Speed = speed;
            Accuracy = accuracy;
            Special = special;
        }

        public void UseWeapon()
        {
            if (Durability > 0)
            {
                Durability--;
                Console.WriteLine($"{Name} was used. Durability reduced to {Durability}.");
                if (Durability == 0)
                {
                    Console.WriteLine($"{Name} broke!");
                }
            }
            else
            {
                Console.WriteLine($"{Name} is already broken!");
            }
        }

        public bool IsBroken()
        {
            return Durability == 0;
        }

        public virtual int Attack()
        {
            Console.WriteLine($"An attack with {Name}");
            return 0;
        }
    }
}