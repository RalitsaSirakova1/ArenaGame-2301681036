using System;

namespace ArenaGame
{
    public class Poison : Weapon
    {
        private int poisonStrength;

        public Poison(string name, int durability, string speed, int accuracy, string special, int strength) : base( name, durability, speed, accuracy, special)
        {
            poisonStrength = strength;
        }

        public void ApplyPoison(Hero target)
        {
            if (!IsBroken())
            {
                target.TakeDamage(poisonStrength);
                Console.WriteLine($"Poison {Name} is being applied to {target.Name}. {target.Name} takes {poisonStrength} poison damage.");
            }
            else
            {
                Console.WriteLine($"The poison {Name} bottle is empty and cannot be used.");
            }
        }
    }
}
