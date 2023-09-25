using System;

namespace _11._Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];

            Console.WriteLine(matriz.Length);

        }

        static void EnseñarTablero()
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    matriz[x, y] = 0;
                }
            }
        }

        static void ColocarUnBarco()
        {

        }
    }
}
