using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicios
{

    //Nueva Clase

    class Program
    {
        static void Main(string[] args)
        {
            string textoMain;
            textoMain = "Hola mundo!";

            asturianizador(ref textoMain);

            Console.WriteLine(textoMain);

            Console.WriteLine("Dame texto");
            y = Convert.ToInt32(Console.ReadLine());
        }

        static void asturianizador(ref string texto) //Aquí falta algo, está incompleto
        {
            texto += 

    }
    class Program1
    {
            static void Main1(string[]args)
            {
                bool tieneDecimales;
                float floatInicial;
                int floatToInt;
                floatInicial = 8.6f;


                floatToInt = CompruebaDecimales(floatInicial, out tieneDecimales);

                Console.WriteLine(floatToInt);
                Console.WriteLine(tieneDecimales);
            }

            static int CompruebaDecimales(float numDecimal, out bool tieneDecimales)
            {
                int enteroResultante = (int)numDecimal;
                if (numDecimal % enteroResultante == 0)
                {
                    tieneDecimales = false;
                }
                else
                {
                    tieneDecimales = true;
                }
                return enteroResultante;
            }
    }
}
