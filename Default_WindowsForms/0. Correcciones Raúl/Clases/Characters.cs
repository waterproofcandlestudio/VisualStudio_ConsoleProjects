using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Character
    {
        private string name;
        private int health;

        public Character(string name = "None", int health = 100)
        {
            this.name = name;
            this.health = health;
        }

        public string GetName() => name;
        public int GetHealth() => health;
    }

    class Player : Character
    {
        public Player(string name = "None", int health = 100) : base(name, health)
        {
        }
    }

    class Enemy : Character
    {
        enum State
        {
            Idle,
            Hostile,
            Patrol,
            Defensive
        }

        public Enemy(string name = "None", int health = 100) : base(name, health)
        {
        }

        public void StateMachine()
        {

        }
    }

    class Ally : Character
    {
        public Ally(string name = "None", int health = 100) : base(name, health)
        {

        }
    }
}
