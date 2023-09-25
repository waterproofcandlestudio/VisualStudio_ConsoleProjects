using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreccionEj01
{
    class Enemy : Character, IAttacker
    {
        public int shield { get; private set; }

        public Enemy
        (
            string name = "none",
            int health = 100,
            int damage = 10,
            int shield = 37
        )
        : base(name, health, damage)
        {
            this.shield = shield;
        }

        public int GetDamage()
        {
            return damage;
        }

        public void RecieveDmg(int damage)
        {
            if(damage > shield)
            {
                health -= shield <= 0 ? damage : damage - shield;
            }
            shield -= damage; //Siguiente clase
        }
    }
}
