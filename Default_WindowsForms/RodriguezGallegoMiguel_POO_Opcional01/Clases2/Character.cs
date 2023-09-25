using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases2
{
    class Character
    {
        protected string Nombre;
        public int Vida { set; get; }
        public int Daño { set; get; }
        public int Escudo { set; get; }

        public Character(string nombre = "None", int vida = 100, int daño = 25, int escudo = 10)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Daño = daño;
            this.Escudo = escudo;
        }

        public string GetName() => Nombre;

        public int GetHealth() => Vida;

        public int GetDamage() => Daño;

    }
    // : == Heredar de...  (Player hereda de character)
    class Player : Character
    {
        public Player(string name = "None", int health = 100, int daño = 25, int escudo = 10) : base(name, health, daño, escudo)
        {
        }
    }
    class Enemy : Character
    {
        enum state
        {
            Idle,
            Hostile,
            Patrol,
            Defensive
        }
        public Enemy(string name = "None", int health = 100, int daño = 25, int escudo = 10) : base(name, health, daño, escudo)
        {
        }
        public void StateMachine()
        {

        }
    }
}
