using System;
using System.Security.Cryptography;

namespace ArenaGame
{
    public class Fairy : Hero
    {
        private const int HealingChance = 30;
        private const int HealingAmount = 50;
        private bool isFlying;

        public Fairy(string name) : base(name)
        {
            isFlying = false;
        }


        public void StartFlying()
        {
            isFlying = true;
        }

        public void StopFlying()
        {
        isFlying = false; 
        }


        public override void TakeDamage(int incomingDamage)
        {
            if (isFlying)
            {
                Heal(HealingAmount);
            }
            else
            {
                if (ThrowDice(HealingChance))
                {
                    Heal(HealingAmount);
                }
                else
                {
                    base.TakeDamage(incomingDamage);
                }
            }
        }
    }
}
