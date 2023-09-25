using System;
using System.Threading;

namespace EjHilos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread myThread = new Thread(() => Hilo("Hilo1", 500));
            myThread.Start();

            Thread mySecondThread = new Thread(() => Hilo("Hilo1", 500));
            mySecondThread.Start();

            Thread myThirdThread = new Thread(() => Hilo("Pepe", 10000));
            myThirdThread.Start();

            Thread.Sleep(100);

            while (true)
            {
                Console.WriteLine("Soy el hilo principal otra vez, esperando input de usuario");
                Thread.Sleep(250);
            }

            var input = Console.ReadLine();
            Console.WriteLine($"El user escribió: {input}");
        }

        //hilo
        private static void Hilo(string nombre, int waitTime)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("El hilo " + nombre + " está vivo!");
                Thread.Sleep(waitTime);
            }
            Console.WriteLine("El hilo " + nombre + "  se va a cerrar");
        }
    }
}