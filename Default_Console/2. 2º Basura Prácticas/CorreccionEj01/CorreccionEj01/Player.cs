using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreccionEj01
{
    class Player : Character, IAtacker
    {
        private int critChance;
        private int critMult;
        private Random rnd = new Random();
        private int randomNum;
        public Player(string name = "none", int health = 100, int damage = 10, int critChance = 0, int critMult = 0) : base(name, health, damage)
        {
            this.critChance = critChance;
            this.critMult = critMult;
            this.randomNum = this.rnd.Next(0, 101);
        }

        public int GetDamage()
        {
            Random rnd = new Random();

            if (critChance < rnd.Next(0, 101)) return damage * critMult;
            else return damage;
        }

        public void RecieveDmg(int damage)
        {
            health -= damage;
        }
    }
}
