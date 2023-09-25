using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreccionEj01
{
    class Character : IAttacker
    {
        public string name { get; private set; }
        public int health { get; protected set; }
        public int damage { get; private set; }

        public Character
        (
            string name = "none",
            int health = 100,
            int damage = 10
        )
        {
            this.name   = name;
            this.health = health;
            this.damage = damage;
        }

        public virtual int GetDamage()
        {
            return damage;
        }

        public virtual void RecieveDmg(int damage)
        {
            health -= damage;
        }
    }
}
