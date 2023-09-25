using System;

namespace Ejercicios_Redes_1
{
    class Program
    {
        private static void Main(string[] args)
        {​​
            int suma = 0;



            Console.WriteLine("Bienvenido al ejercicio de suma");
            Console.WriteLine("Introduzca números hasta que desee parar, " +
            "para ello escriba \"suma\" ");



            do
            {​​
                Console.Write("Número: ");
                string nums = Console.ReadLine();
                if (nums != "suma")
                {​​
                    int resultado = 0;



                    if (int.TryParse(nums, out resultado))
                    {​​
                        suma += resultado;
                    }​​
                    else
                    {​​
                        Console.WriteLine("El valor " + nums + " no es un número, introduce un número");
                    }​​
                }​​
                else
                {​​
                    break;
                }​​
            }​​
            while (true) ;



            Console.WriteLine("La suma de sus números es: " + suma);



            Console.ReadKey();
        }​​
    }
}
