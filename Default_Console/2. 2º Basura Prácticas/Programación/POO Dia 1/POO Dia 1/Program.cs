using System;

namespace POO_Dia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce n:");
            int n = Convert.ToInt32(Console.ReadLine());
            double fact = n;

            Fibonacci(n);
            FactIterative(n, fact);
            ShowFactRec(n, fact);
        }

        private static void Fibonacci(int n)
        {
            Console.WriteLine("Los primeros {0} números de fibonacci son ");
            int first = 0;
            int second = 1;

            // Darle 2 veces a tabulador tras poner el for para 
            // construirlo entero casi automáticamente
            for (int i = 0; i < n; i++)
            {
                if      (i == 0) Console.WriteLine("0");
                else if (i == 1) Console.WriteLine("1");
                else
                {
                    int current = first + second;
                    Console.WriteLine("{0}", current);
                    first = second;
                    second = current;
                }
            }

            Console.WriteLine();
        }

        private static void FactIterative(int n, double fact)
        {
            for (int i = n; i > 1; i--)
            {
                fact = fact * i;
            }
        }

        private static void ShowFactRec(int n, double fact)
        {
            Console.WriteLine("El factorial de {0} es: {1}", n, fact);
        }

        private static double FactRecursive(int n)
        {
            if (n <= 1) return 1;
            else return FactRecursive(n - 1) * n;
        }
    }
}
