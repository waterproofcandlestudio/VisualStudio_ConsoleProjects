using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreccionEj01
{
    class Enemy : Character
    {
        public enum Tactic
        {
            Defensive,
            Ofensive,
            Flee,
            Flank,
            Counter
        }

        public Tactic myTactic;
        public int shield { get; private set; }

        public Enemy
        (
            string name = "none",
            int health = 100,
            int damage = 10,
            int shield = 37,
            Tactic myTactic = Tactic.Defensive
        )
        : base(name, health, damage)
        {
            this.shield = shield;
            this.myTactic = myTactic;
        }

        public override void RecieveDmg(int damage)
        {
            if(damage > shield)
            {
                health -= shield <= 0 ? damage : damage - shield;
            }

            shield -= (int)Math.Round(damage * 0.5f);
        }

        public override int GetDamage()
        {
            if(myTactic == Tactic.Ofensive) return base.GetDamage() * 2;
            else                            return base.GetDamage();
        }
    }
}
