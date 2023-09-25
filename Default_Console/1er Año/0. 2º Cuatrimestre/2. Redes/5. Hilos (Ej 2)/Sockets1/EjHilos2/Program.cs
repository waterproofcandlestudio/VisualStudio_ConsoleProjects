using System;
using System.Threading;

namespace EjHilos2
{
    class Program
    {
        private static void Main(string[] args)
        {
            string input = " ";

            while (input != "exit")
            {
                input = Console.ReadLine();
                Thread h1;

                if (input != "exit")
                {
                    h1 = new Thread(() => Hilo1(input, 5000));
                    h1.Start();
                }
            }
        }

        //hilo 1
        private static void Hilo1(string nombre, int waitTime)
        {
            while (nombre != "exit")
            {
                Console.WriteLine("Hola " + nombre);
                Thread.Sleep(waitTime);
            }           
        }
    }
}
