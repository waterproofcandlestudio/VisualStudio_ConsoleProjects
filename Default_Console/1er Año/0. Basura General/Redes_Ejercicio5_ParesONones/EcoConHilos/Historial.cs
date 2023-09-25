using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redes_Ejercicio5_ParesONones
{
    class Historial
    {
        string[] mensajes = new string[512];
        int i = 0;

        public string procesarMensaje(string m)
        {
            if (i == mensajes.Length)
            {
                i = 0;
            }
            mensajes[i] = m;
            Console.WriteLine("Procesar Mensaje = " + mensajes[i] + " índice = " + i);
            i++;

            return m.ToUpper();            
        }

        public void MostrarHistorial()
        {
            Console.WriteLine("** Historial de mensajes **");

            if (HistorialVacio())
            {
                Console.WriteLine("No existe historial de mensajes");
            }
            else
            {
                Console.WriteLine("HISTORIAL DE MENSAJES ANTERIORES: ");

                for (int i = 0; i < mensajes.Length; i++)
                {
                    if (mensajes[i] != null)
                    {
                        Console.WriteLine(mensajes[i] + " Índice = " + i);
                    }
                }
            }
        }

        public bool HistorialVacio()
        {
            if (mensajes.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
