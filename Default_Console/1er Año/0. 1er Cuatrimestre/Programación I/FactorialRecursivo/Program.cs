using System;

namespace FactorialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
			// Declaro variables
			int num;
			int result = 1;
			string valorRecogido;

			// Pido el valor al usuario
			Console.Write("Introduce un numero a factorizar : ");

			// Recojo el valor y lo meto el el string "valorRecogido"
			valorRecogido = Console.ReadLine();
			num = Convert.ToInt32(valorRecogido);

			// Hago un bucle for para factorizar
			// La variable "i" sirve como indice que va subiendo conforme se van multiplicando los números desde 1 hasta el valor introducido para hacer una factorización recursiva.
			for (int i = 2; i <= num; i++)
			{
				// Se multiplica el resultado en bucle por el indice "i" de manera recursiva hasta que "i" sea igual al valor introducido.
				result = result * i;
			}
			Console.WriteLine("El factorial de " + num + " es " + result);

			// Paro el programa
			Console.Write("Pulse una tecla para salir");
			Console.ReadLine();
		}
    }
}
