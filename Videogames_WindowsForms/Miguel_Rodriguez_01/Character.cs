/*
 *  Creador: Miguel Rodríguez Gallego
 *  Fecha: 25.enero.2021
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miguel_Rodriguez_01
{
    // Clase Padre jugador
    class Character
    {
        public enum CharacterType
        {
            Sword   =   0,
            Axe     =   1,
            Spear   =   2
        }

        public Image picture { get; private set; }
        protected CharacterType type { get; private set; }
        public string name { get; private set; }
        public int health { get; set; }
        public int dmg;

        public Character
            (
            Image picture,
            CharacterType type,
            string name = "None",
            int health = 1,
            int dmg = 1
            )
        {
            this.picture = picture;
            this.type = type;
            this.name = name;
            this.health = health;
            this.dmg = dmg;
        }
    }

    // Clase del jugador
    class ChPlayer : Character, IAttacker
    {

        public ChPlayer
        (
            Image picture,
            CharacterType type,
            string name = "None",
            int health = 1,
            int dmg = 1
        )
        : base (picture, type, name, health, dmg)
        {
        }

        public int GetDmg()
        {
            return dmg;
        }
        public CharacterType GetDmgType()
        {
            return type;
        }
        public void ReceiveDmg(int dmg, CharacterType attType)
        {
            health -= Battle.CalculateDmg(attType, type, dmg);
        }
    }

    // Clase de los enemigos
    class ChEnemy : Character, IAttacker
    {

        public ChEnemy
        (
            Image picture,
            CharacterType type,
            string name = "None",
            int health = 1,
            int dmg = 1
        ) 
        : base(picture, type, name, health, dmg)
        {
        }

        public int GetDmg()
        {
            return dmg;
        }
        public CharacterType GetDmgType()
        {
            return type;
        }
        public void ReceiveDmg(int dmg, CharacterType attType)
        {
            health -= Battle.CalculateDmg(attType, type, dmg);
        }
    }

    // Control de la batalla y los daños
    static class Battle
    {
        private static float[,] typeTable = new float[,] //[row, column]
        {
            //[att, def]     Sword  Axe   Spear
            /*Sword*/       { 1.0f, 2.0f, 0.5f },
            /*Axe*/         { 0.5f, 1.0f, 2.0f },
            /*Spear*/       { 2.0f, 0.5f, 1.0f }
        };

        public static int CalculateDmg(Character.CharacterType attType, Character.CharacterType defType, int attDmg)
        {
            return ((int)typeTable   [(int)attType, (int)defType]    *   attDmg);
        }
    }
}
