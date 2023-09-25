// Miguel Rodriguez Gallego
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Clase principal
namespace Apartado2_Práctica01_MiguelRodríguezGallego
{
    class JugadorFueraDePorteria : Portero
    {
        public int GolesAnotados { get;  set; }

        public JugadorFueraDePorteria
        (
            string nombre = "none",
            string posicion = "none",
            int numUnif = 0,
            double minJug = 0,
            int golAnot = 0
        )
            : base(nombre, posicion, numUnif, minJug)
        {
            this.GolesAnotados = golAnot;
        }
    }
}
