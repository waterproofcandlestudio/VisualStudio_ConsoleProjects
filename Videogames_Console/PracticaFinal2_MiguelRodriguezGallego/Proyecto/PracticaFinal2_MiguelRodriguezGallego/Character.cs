// Miguel Rodríguez Gallego
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal2_MiguelRodriguezGallego
{
    class Character : Banking
    {
        // Estadísticas principales
        public string name { get; private set; }
        public int health { get; protected set; }
        public int damage { get; set; }
        public int shield { get; set; }

        // Contador total de puntos 
        public int totalPoints { get; set; }
        // Propiedad q recoge si el personaje ha cogido un as para q pueda valer 1/11 dependiendo d lo q mejor le venga al jugador
        public int ace { get; set; }
        // Recojo la última carta del jugador para q la pueda devolver con un modificador
        public int lastCard { get; protected set; }

        // Contadores d los modificadores
        public int rb10Damage { get; set; }
        public int rb10Shield { get; set; }
        public int returnLastCard { get; set; }
        public int rbLimit24 { get; set; }
        public int rbLimit27 { get; set; }
        public int rbCardNumMinus2 { get; set; }

        public Character
        (
            string name = "none",
            int health = 0,
            int damage = 0,
            int shield = 0,

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
            : base (coin, bet)
        {
            this.name   = this.NameRandomizer();
            this.health = health;
            this.damage = damage;
            this.shield = shield;

            this.totalPoints = totalPoints;
            this.ace = ace;
            this.lastCard = lastCard;

            this.rb10Damage = rb10Damage;
            this.rb10Shield = rb10Shield;
            this.returnLastCard = returnLastCard;
            this.rbLimit24 = rbLimit24;
            this.rbLimit27 = rbLimit27;
            this.rbCardNumMinus2 = rbCardNumMinus2;
        }
        // Generador aleatorio de nombres para los enemigos
        public virtual string NameRandomizer()
        {
            int numPersonaje = Utilities.RandNumNameGen(0, 19);
            int numAdjetivo = Utilities.RandNumNameGen(0, 17);

            string[] personajes = new string[] { "Pitbull", "IlloJuan", "Ozuna", "Nadal", "Alonso", "Gigante Noble", "Gabe Newell", "Eminem", "Shreck", "Will Smith", "El Admin", "Lebron James", "Aquarius", "El Kun", "Schwarzenegger", "La Roca", "Joan", "Messi", "CR7" };
            string[] adjetivos = new string[] { "calvo", "nudista", "derrapando", "con depresión", "fumeta", "culturista", "piscinero", "gitano", "picao", "con olor a podrido", "manco", "ciego", "rabioso", "bully", "pacifista", "triste", "vamo a juga" };

            return personajes[numPersonaje] + " " + adjetivos[numAdjetivo];
        }
    }
}
