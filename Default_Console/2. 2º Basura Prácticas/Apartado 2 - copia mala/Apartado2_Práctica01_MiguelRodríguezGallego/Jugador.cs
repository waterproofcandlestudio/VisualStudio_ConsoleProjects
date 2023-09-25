using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartado2_Práctica01_MiguelRodríguezGallego
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Posicion { get; private set; }
        public int NumeroUniforme { get;  set; }
        public double MinutosDeJuego { get;  set; }
        public int GolesAnotados { get;  set; }

        public Jugador
        (
            string nombre = "none",
            string posicion = "none",
            int numUnif = 0,
            double minJug = 0,
            int golAnot = 0
        )
        {
            this.Nombre = nombre;
            this.Posicion = posicion;
            this.NumeroUniforme = numUnif;
            this.MinutosDeJuego = minJug;
            this.GolesAnotados = golAnot;
        }
    }
}
