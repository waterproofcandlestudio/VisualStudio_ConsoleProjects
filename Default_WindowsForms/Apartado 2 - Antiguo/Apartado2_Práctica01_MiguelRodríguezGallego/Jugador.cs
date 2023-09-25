using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartado2_Práctica01_MiguelRodríguezGallego
{
    class Jugador
    {
        public string nombre { get; set; }
        public string posicion { get; private set; }
        public int numUnif { get;  set; }
        public double minJug { get;  set; }
        public int golAnot { get;  set; }

        public Jugador
        (
            string nombre = "none",
            string posicion = "none",
            int numUnif = 0,
            double minJug = 0,
            int golAnot = 0
        )
        {
            this.nombre = nombre;
            this.posicion = posicion;
            this.numUnif = numUnif;
            this.minJug = minJug;
            this.golAnot = golAnot;
        }
    }
}
