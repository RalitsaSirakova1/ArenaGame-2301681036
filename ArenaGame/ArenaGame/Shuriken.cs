namespace ArenaGame
{
    public class Shuriken : Weapon
    {
        public Shuriken(string name, int durability, string speed, int accuracy, string special) : base(name, durability, speed, accuracy, special) { }

        public override int Attack()
        {
            return 5;
        }

        public void Throw(Hero target)
        {
            if (!IsBroken())
            {
                int damage = base.Attack();
                int totalDamage = (int)(damage * 1.5);
                target.TakeDamage(totalDamage);
                Console.WriteLine($"{Name} is thrown at {target.Name}! Inflicted {totalDamage} damage.");
            }
        }
    }
}