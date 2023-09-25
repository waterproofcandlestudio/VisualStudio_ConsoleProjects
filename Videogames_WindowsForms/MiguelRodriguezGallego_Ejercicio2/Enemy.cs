using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiguelRodriguezGallego_Ejercicio2
{
    class Enemy : Character
    {
        public string tipoDeEnemigo { get; private set; }

        public Enemy
        (
            string name = "none",
            int health = 100,
            int damage = 10,
            string tipoDeEnemigo = "none",
            string tipoDeAtaque = "none"
        )
        : base(name, health, damage, tipoDeAtaque)
        {
            this.tipoDeEnemigo = tipoDeEnemigo;
        }

        public override int AtaqueNormal()
        {
            return damage;
        }
    }
}
