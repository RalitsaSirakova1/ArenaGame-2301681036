using System;

namespace ArenaGame
{
    public class Nymph : Hero
    {
        private const int EnchantingSongChance = 60;
        private const int EnchantingSongDuration = 7;
        private const int EnchantingSongMultiplier = 10;

        private int enchantingSongTurnsRemaining;

        public Nymph(string name) : base(name)
        {
            enchantingSongTurnsRemaining = 0;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (enchantingSongTurnsRemaining > 0)
            {
                incomingDamage = (int)(incomingDamage / EnchantingSongMultiplier);
            }

            base.TakeDamage(incomingDamage);
        }

        public void EnchantingSong()
        {
            if (ThrowDice(EnchantingSongChance))
            {
                enchantingSongTurnsRemaining = EnchantingSongDuration;
            }
        }
        public override int Attack()
        {
            int attackDamage = base.Attack();

            if (enchantingSongTurnsRemaining > 0)
            {
                attackDamage = (attackDamage * EnchantingSongMultiplier);
            }

            return attackDamage;
        }

    }
}
