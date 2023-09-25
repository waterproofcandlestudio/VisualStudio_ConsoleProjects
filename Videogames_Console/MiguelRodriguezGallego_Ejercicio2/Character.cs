using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiguelRodriguezGallego_Ejercicio2
{
    class Character
    {
        public string name { get; private set; }
        public int health { get; protected set; }
        public int damage { get; private set; }
        public string tipoDeAtaque { get; private set; }

        public Character
        (
            string name = "none",
            int health = 100,
            int damage = 10,
            string tipoDeAtaque = "none"
        )
        {
            this.name   = name;
            this.health = health;
            this.damage = damage;
            this.tipoDeAtaque = tipoDeAtaque;
        }

        public virtual int AtaqueNormal()
        {
            return damage;
        }

        public virtual int AtaqueFuego(string tipoDeEnemigo)
        {
            return damage;            
        }

        public virtual int AtaqueAgua(string tipoDeEnemigo)
        {
            return damage;
        }

        public virtual int AtaquePlanta(string tipoDeEnemigo)
        {
            return damage;
        }

        public virtual void RecieveDmg(int damage)
        {
            health -= damage;
        }
    }
}
