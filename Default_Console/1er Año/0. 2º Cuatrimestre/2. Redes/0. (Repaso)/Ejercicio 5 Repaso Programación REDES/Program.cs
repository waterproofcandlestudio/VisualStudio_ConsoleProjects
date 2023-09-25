using System;
using System.IO;

namespace Ejercicio_5_Repaso_Programación_REDES
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Ejercicio 5
                Haz un programa que detecte la penúltima palabra de una frase que el usuario introduzca
                Ejemplo:
                >>>Estoy en la clase de redes y me aburro un poco
                SALIDA>>>un
            */

            string frase;
            string[] palabras = new string[100];
            int ultima = 0;
            int j = 0;

            Console.WriteLine("Escribe 1 frase y luego te muestro por pantalla la penúltima palabra");
            frase = Console.ReadLine();


            for (int i = 0; i < frase.Length + 1; i++)
            {
                string palabra = "";
                bool mismaPalabra = true;

                while (mismaPalabra)
                {
                    if (i == frase.Length || frase.Substring(i, 1) == " ")
                    {
                        mismaPalabra = false;
                    }
                    else 
                    { 
                        palabra = palabra + frase[i];
                        i++;
                    }
                }
                palabras[j] = palabra;
                ultima = j;
                j++;
            }

            Console.WriteLine("La penúltima palabra de la frase es: " + palabras[ultima - 1]);
        }
    }
}
