using System;

namespace Factorial_temporal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un Nº y le hago el factorial");
            int numFac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(numFac));
            Numerar(numFac);
        }

        static int Factorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            return x * Factorial(x - 1);
        }

        static void Numerar(int x)
        {
            if (x >= 1)
            {
                Console.WriteLine(x);
                Numerar(x - 1);
            }
            else
                Console.WriteLine(x);
        }
    }
}
