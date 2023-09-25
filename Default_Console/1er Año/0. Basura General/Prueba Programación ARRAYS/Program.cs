using System;

namespace Prueba_Programación
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            string dato = "";
            int i = 0;

            Console.WriteLine("Escribe nombres y te los guardo");
            

            while (dato != "salir" && i < 10)
            {
                dato = Console.ReadLine();
                nombres[i] = dato;
                i++;
            }
            Console.WriteLine("Elementos del array nombres sin ordenar: ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            Array.Sort(nombres);
            Console.WriteLine("Elementos del array nombres ordenados: ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            Array.Reverse(nombres);
            Console.WriteLine("Elementos del array nombres ordenados al revés: ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            Array names = Array.CreateInstance(typeof(string), 10);
            Array.Copy(nombres, names, 10);
            Console.WriteLine("Elementos del array nombres ordenados: " + names);
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
