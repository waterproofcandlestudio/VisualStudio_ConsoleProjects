// Miguel Rodríguez Gallego
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal2_MiguelRodriguezGallego
{
    class Player : Character
    {
        public Player
        (
            string name,
            int health     = 0,
            int damage     = 0,
            int shield     = 0,

            int totalPoints = 0,
            int ace = 0,
            int lastCard = 0,
            int coin = 0,
            int bet = 0,

            int rb10Damage = 0,
            int rb10Shield = 0,
            int returnLastCard = 0,
            int rbLimit24 = 0,
            int rbLimit27 = 0,
            int rbCardNumMinus2 = 0
        )
        : base (name, health, damage, shield, totalPoints, ace, lastCard, coin, bet, rb10Damage, rb10Shield, returnLastCard, rbLimit24, rbLimit27, rbCardNumMinus2)
        {

        }

        public void ReceiveDamagePlayer(int health, int damage, int shield)
        {
            // [1er Daño ==> Vida (& escudo <=> es < q el daño del enemigo]
            if (shield < damage)    {   DamageHealthPlayer(health, damage, shield); }
            // [2º Daño ==> Escudo (<=> es > q el daño del enemigo] 
            else                    {   DamageShieldPlayer(damage, shield);         }
        }
        private void DamageHealthPlayer(int health, int damage, int shield)
        {
            this.health = (health + shield) - damage;
            this.shield = 0;
        }
        private void DamageShieldPlayer(int damage, int shield) {this.shield = shield - damage;}
        // Le quito el modificador de tener +10 daño por una ronda tras atacar al otro jugador      
        public int DamageTo0(int damage)
        {
            while (damage > 20)     {   damage--;   }
            return this.damage = damage;
        }       
        public virtual int GetLastCard(int p1LastCard, int pickedCard)
        {
            return this.lastCard = pickedCard;
        }

        public virtual void RandomMuutusChecker(int randMuutus, int rb10Damage, int rb10Shield, int returnLastCard, int rbLimit24, int rbLimit27, int rbCardNumMinus2)
        {
            // Según el modificador aleatorio que toque añado 1 uso suyo para poder usarlo el usuario
            if (randMuutus == 0)    {   this.rb10Damage++;      }
            if (randMuutus == 1)    {   this.rb10Shield++;      }
            if (randMuutus == 2)    {   this.returnLastCard++;  }
            if (randMuutus == 3)    {   this.rbLimit24++;       }
            if (randMuutus == 4)    {   this.rbLimit27++;       }
            if (randMuutus == 5)    {   this.rbCardNumMinus2++; }
        }
    }
}
