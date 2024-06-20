namespace ArenaGame
{
    public class Sword : Weapon
    {
        public Sword(string name, int durability, string speed, int accuracy, string special) : base(name, durability, speed, accuracy, special)
        {

        }

        public override int Attack()
        {
            return 10;
        }

        public void Slash(Hero target)
        {
            int damage = base.Attack();
            int totalDamage = damage * 2;
            target.TakeDamage(totalDamage);
            Console.WriteLine($"{Name} slashes {target.Name}! Inflicted {totalDamage} damage.");
        }
    }
}
