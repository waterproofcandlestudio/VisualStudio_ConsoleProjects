using System;

namespace MiguelRodríguezGallego._1ºvideojuegos
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            do
            {
                Console.WriteLine("Presiona 1 para empezar a jugar");
                Console.WriteLine("Presiona 2 para ver las opciones");
                Console.WriteLine("Presiona 3 para ver los créditos");
                Console.WriteLine("Presiona 4 para salir");

                bool salir = false;

                while (!salir)
                {
                    Menu();
                    {
                        Console.WriteLine("Estas en el menu");
                    }
                }

                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        Console.WriteLine("Entrada inválida");
                        break;

                    case 1:
                        Console.WriteLine("Vamos a empezar la partida");
                        break;

                    case 2:
                        Console.WriteLine("Cargando opciones");
                        break;

                    case 3:
                        Console.WriteLine("Cargando Créditos");
                        break;

                    case 4:
                        Console.WriteLine("Saliendo");
                        break;
                }

            }
            while (input != 4);

        }

        static void
        
        static void jugar()
        {
            Console.WriteLine("Estas jugando");
        }

        static void opciones()
        {
            Console.WriteLine("Estas en el menu de opciones")
        }

        static void creditos()
        {
            Console.WriteLine("Estos son los créditos");
        }

        static void salir()
        {
            Console.WriteLine("Saliendo")
        }

    }
}
