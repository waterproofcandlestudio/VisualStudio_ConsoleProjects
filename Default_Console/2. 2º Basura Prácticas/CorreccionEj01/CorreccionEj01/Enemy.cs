using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreccionEj01
{
    class Enemy : Character
    {
        private int shield;
        public Enemy(string name = "none", int health = 100, int damage = 10) : base(name, health, damage)
        {
            this.shield = shield;
        }

        public int GetDAmage()
        {
            return damage;
        }

        public void RecieveDmg(int damage)
        {
            if(damage > shield)
            {
                health -= shield <= 0 ? damage : damage - shield;
                /*
                if(shield <= 0)
                {
                    health -= damage;
                }
                else
                {
                    health -= damage - shield;
                }
                */
            }
        }
    }
}
