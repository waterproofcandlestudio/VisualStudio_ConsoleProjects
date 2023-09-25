using Microsoft.VisualBasic;
using System;

namespace BasicCode04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string myStringHo = "Hola";
            Ho(ref myStringHo);
            Console.WriteLine(myStringHo);
            float myFloatDE = 2.54f;
            bool tieneDecimales;
            Console.WriteLine(DecimalEntero(myFloatDE, out tieneDecimales));
            Console.WriteLine(tieneDecimales);
        }
        static void Ho(ref string texto)
        {
            texto = texto + ", ho";
        }
        static int DecimalEntero(float myFloat, out bool tieneDecimales)
        {
            int enteroResultante = (int)myFloat;
            if (myFloat % enteroResultante == 0)
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
