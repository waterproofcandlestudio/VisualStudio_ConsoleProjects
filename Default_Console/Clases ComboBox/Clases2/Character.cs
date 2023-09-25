using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases2
{
    class Character
    {
        protected string nombre;
        public int vida { set; private get; }

        public Character(string nombre = "None", int vida = 100)
        {
            this.nombre = nombre;
            this.vida = vida;
        }

        public string GetName() => nombre;

        public int GetHealth() => vida;


        /*
        public string Name
        {
            get
            {
                return "My name is " + name;
            }
            set
            {
                name = value;
            }
        }
        */
    }
    // : == Heredar de...  (Player hereda de character)
    class Player : Character
    {
        public Player(string name = "None", int health = 100) : base(name, health)
        {
            this.nombre = name;
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
        public Enemy(string name = "None", int health = 100) : base(name, health)
        {
            this.nombre = name;
        }
        public void StateMachine()
        {

        }

    }
    class Ally : Character
    {
        public Ally(string name = "None", int health = 100) : base(name, health)
        {
            this.nombre = name;
        }

    }
}
