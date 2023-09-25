using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ajustar temporizador
            Console.WriteLine("Escribe los días");
            int dias;
            do
            {
                dias = Convert.ToInt32(Console.ReadLine());
                if (dias < 0)
                    Console.WriteLine("El valor debe ser positivo. Prueba otra vez");
            }
            while (dias < 0);
            Console.WriteLine("Escribe las horas");
            int horas;
            do
            {
                horas = Convert.ToInt32(Console.ReadLine());
                if (horas < 0)
                    Console.WriteLine("El valor debe ser positivo. Prueba otra vez");
            }
            while (horas < 0);
            Console.WriteLine("Escribe los minutos");
            int minutos;
            do
            {
                minutos = Convert.ToInt32(Console.ReadLine());
                if (minutos < 0)
                    Console.WriteLine("El valor debe ser positivo. Prueba otra vez");
            }
            while (minutos < 0);
            Console.WriteLine("Escribe los segundos");
            int segundos;
            do
            {
                segundos = Convert.ToInt32(Console.ReadLine());
                if (segundos < 0)
                    Console.WriteLine("El valor debe ser positivo. Prueba otra vez");
            }
            while (segundos < 0);
            while (segundos >= 60)
            {
                segundos = segundos - 60;
                minutos = minutos + 1;
            }
            while (minutos >= 60)
            {
                minutos = minutos - 60;
                horas = horas + 1;
            }
            while (horas >= 24)
            {
                horas = horas - 24;
                dias = dias + 1;
            }

            Console.WriteLine("Días:" + dias + " Horas:" + horas + " Minutos:" + minutos + " Segundos:" + segundos);


            // Comprobador de años bisiestos
            Console.WriteLine("Escribe un año para comprobar si es bisiesto");
            int año = Convert.ToInt32(Console.ReadLine());
            bool bisiesto;
            if ((año % 4) == 0)
                bisiesto = true;
            else
                bisiesto = false;
            if ((año % 100) == 0)
                bisiesto = false;
            if ((año % 400) == 0)
                bisiesto = true;


            if (bisiesto == true)
                Console.WriteLine("El año es bisiesto");
            else
                Console.WriteLine("El año NO es bisiesto");

            // Traductor
            Console.WriteLine("Escribe un número del 1 al 10");
            int number;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    case 10:
                        Console.WriteLine("Ten");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo");
                        break;
                    default:
                        Console.WriteLine("El número debe ser entre 0 y 10. Prueba otra vez");
                        break;
                }
            } while (number != 0);



            // Calcular Factorial
            Console.WriteLine("Escribe un número para calcular su factorial");
            int numeroFac = Convert.ToInt32(Console.ReadLine());
            int aux = 1;
            int resultado3 = 1;
            while (aux <= numeroFac)
            {
                resultado3 = resultado3 * aux++;
            }
            Console.WriteLine("El factorial de " + numeroFac + " es " + resultado3);

            // Juego Adivina el número 2.0
            Random myRandom = new Random();
            int RandomNum = myRandom.Next(0, 100);
            Console.WriteLine("Adivina el número entre 0 y 100");
            int ProbarNumero;
            int intentos = 0;
            do
            {
                intentos = intentos + 1;
                ProbarNumero = Convert.ToInt32(Console.ReadLine());
                if (ProbarNumero > RandomNum)
                    Console.WriteLine("El número que has puesto es mayor");
                else if (ProbarNumero < RandomNum)
                    Console.WriteLine("El número que has puesto es menor");
                else
                    Console.WriteLine("Has acertado!");

            }
            while (ProbarNumero != RandomNum);
            Console.WriteLine("Intentos necesitados: " + intentos);


            // Cuadrovoid
            Console.WriteLine("Escribe el número de filas");
            int filas;
            do
            {
                filas = Convert.ToInt32(Console.ReadLine());
                if (filas <= 0)
                    Console.WriteLine("El valor debe ser mayor que 0. Prueba otra vez");
            }
            while (filas <= 0);
            Console.WriteLine("Escribe el número de columnas");
            int columnas;
            do
            {
                columnas = Convert.ToInt32(Console.ReadLine());
                if (columnas <= 0)
                    Console.WriteLine("El valor debe ser mayor que 0. Prueba otra vez");
            }
            while (columnas <= 0);
            string objeto = "X";
            string espacio = "  ";
            string tronco = objeto;
            for (int q = 1; q <= (columnas - 2); ++q)
            {
                tronco = tronco + espacio;
            }
            if (columnas > 1)
                tronco = tronco + " " + objeto;


            for (int i = 1; i <= columnas; ++i)
            {
                Console.Write(objeto + " ");
            }
            Console.WriteLine(" ");
            for (int i = 1; i <= (filas - 2); ++i)
            {
                Console.WriteLine(tronco);
            }
            if (filas != 1)
                for (int i = 1; i <= columnas; ++i)
                {
                    Console.Write(objeto + " ");
                }

            Console.WriteLine("");






            Console.ReadKey();
        }
    }
}
