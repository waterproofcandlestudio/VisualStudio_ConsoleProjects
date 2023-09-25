using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiguelRodriguezGallego_Ejercicio2
{
    class Player : Character
    {
        public int critChance { get; private set; }
        public int critMult { get; private set; }

        public Player
        (
            string name    = "none",
            int health     = 100,
            int damage     = 10,
            int critChance = 0,
            int critMult   = 0,
            string tipoDeEnemigo = "none",
            string tipoDeAtaque = "none"
        )
        : base (name, health, damage, tipoDeAtaque)
        {
            this.critChance = critChance;
            this.critMult   = critMult;
        }

        public override int AtaqueNormal()
        {
            Random rnd = new Random();

            if (critChance > rnd.Next(0, 101)) return damage * critMult;
            else return damage;
        }

        public override int AtaqueFuego(string tipoDeEnemigo)
        {
            if (tipoDeEnemigo == "Planta")
            {
                return damage * 2;
            }
            if (tipoDeEnemigo == "Agua")
            {
                return damage * 0;
            }
            else
            {
                return damage;
            }
        }

        public override int AtaqueAgua(string tipoDeEnemigo)
        {
            if (tipoDeEnemigo == "Fuego")
            {
                return damage * 2;
            }
            if (tipoDeEnemigo == "Planta")
            {
                return damage * 0;
            }
            else
            {
                return damage;
            }
        }

        public override int AtaquePlanta(string tipoDeEnemigo)
        {
            if (tipoDeEnemigo == "Agua")
            {
                return damage * 2;
            }
            if (tipoDeEnemigo == "Fuego")
            {
                return damage * 0;
            }
            else
            {
                return damage;
            }
        }      
    }
}
