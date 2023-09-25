using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica01_MiguelRodríguezGallego
{
    class Punto
    {
        public string name { get; private set; }
        public double x { get; set; }
        public double y { get;  set; }

        public Punto
        (
            string name = "none",
            double x = 0,
            double y = 0
        )
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
    }
}
