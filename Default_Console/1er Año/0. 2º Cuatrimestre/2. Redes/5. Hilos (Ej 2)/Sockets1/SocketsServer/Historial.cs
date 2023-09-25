using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilos
{
    class Historial
    {
        string[] mensajes = new string[512];
        int i;

        public string[] procesarMensaje(string m)
        {
            i++;
            if (i == mensajes.Length)
            {
                i = 0;
            }
            mensajes[i] = m;
            if (m == "historial")
            {
                return mensajes;
            }
            else
            {
                string[] msg = new string[512];
                msg[0] = m.ToUpper();
                return msg;
            }
        }
    }
}
