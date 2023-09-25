// Miguel Rodríguez Gallego
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal2_MiguelRodriguezGallego
{
    class Utilities
    {
        // Utilidad para generar números aleatorios en un rango de valores
        public static int RandNumNameGen(int inicio, int fin)
        {
            Random rnd = new Random();
            int randNum = rnd.Next(inicio, fin);
            return randNum;
        }

        public static int RandomCard()
        {
            // Pongo q "randNum" pueda ser hasta 12 pq sino se produce un "Stack Overflow" cuando cojo 11 cartas en una ronda.
            // El programa necesita otro nº fuera d los límites establecidos de mi baraja para funcionar.
            // [CASO EXCEPCIONAL] Seguramente nunca se va a dar, pero lo pongo por si pueda pasar.
            Random rnd = new Random();
            int randNum = rnd.Next(1, 12);
            return randNum;
        }

        public static int RandMuutusPlayer()
        {
            Random rndP1 = new Random();
            int randMuutusP1 = rndP1.Next(0, 6);
            return randMuutusP1;
        }
    }
}
