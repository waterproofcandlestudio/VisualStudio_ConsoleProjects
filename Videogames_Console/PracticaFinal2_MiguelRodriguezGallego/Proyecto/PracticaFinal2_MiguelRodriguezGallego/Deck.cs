// Miguel Rodríguez Gallego
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal2_MiguelRodriguezGallego
{
    class Deck
    {
        public int NumCards { get; set; }

        public Deck
        (
            int numCards = 11
        )
        {
            this.NumCards = numCards;
        }
    }
}
