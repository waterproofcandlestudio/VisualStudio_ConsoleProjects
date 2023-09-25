using System;
using System.Threading;

namespace Hilos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread h1 = new Thread(() => Hilo1("Hilo1", 100));
            h1.Start();

            Thread h2 = new Thread(() => Hilo2("Hilo2", 1000));
            h2.Start();

            // El programa principal espera a que pulse una tecla
            var input = Console.ReadLine();
        }

        //hilo 1
        private static void Hilo1(string nombre, int waitTime)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("El hilo " + nombre + " está vivo!");
                Thread.Sleep(waitTime);
            }
        }

        //hilo 2
        private static void Hilo2(string nombre, int waitTime)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("El hilo " + nombre + " está vivo!");
                Thread.Sleep(waitTime);
            }
        }
    }
}