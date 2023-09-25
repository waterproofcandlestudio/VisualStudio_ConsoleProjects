// Miguel Rodriguez Gallego
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartado2_Práctica01_MiguelRodríguezGallego
{
    class Portero
    {
        // Principales instancias de los jugadores para establecer los principales datos a manejar y transmitir a las clases hijas "Defensa", "Medio", "Delantero" y "Portero" por herencia
        // Declaro las propiedades de clase / campos de clase
        public string Nombre { get; set; }
        public string Posicion { get; private set; }
        public int NumeroUniforme { get; set; }
        public double MinutosDeJuego { get; set; }

        public Portero
        (
            string nombre = "none",
            string posicion = "Portero",
            int numUnif = 0,
            double minJug = 0
        )
        {
            this.Nombre = nombre;
            this.Posicion = posicion;
            this.NumeroUniforme = numUnif;
            this.MinutosDeJuego = minJug;
        }
    }
}
