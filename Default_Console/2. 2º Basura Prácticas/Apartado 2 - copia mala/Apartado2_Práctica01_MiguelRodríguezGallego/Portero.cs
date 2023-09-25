using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartado2_Práctica01_MiguelRodríguezGallego
{
    class Portero : Jugador
    {
        public Portero
        (
            string nombre = "none",
            string posicion = "Portero",
            int numUnif = 0,
            double minJug = 0,
            int golAnot = 0
        )
            : base(nombre, posicion, numUnif, minJug, golAnot)
        {

        }
    }
}
