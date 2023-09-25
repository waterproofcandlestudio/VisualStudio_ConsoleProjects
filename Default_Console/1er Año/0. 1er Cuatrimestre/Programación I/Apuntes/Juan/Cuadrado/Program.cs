using System;
using System.Security.Cryptography;

namespace BaseCode01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            // Espera a que el usuario presione una tecla
            Console.WriteLine("Esto saldrá escrito en una línea");
            Console.Write("Esto irá");
            Console.Write(" en la misma línea");
            /* Esto es un
            comentario multilínea
            */

            string saludo = "Hola Mundo";
            Console.WriteLine(saludo);

            int numero = 10;
            Console.WriteLine(numero);

            string texto;
            texto = "Hola";
            Console.WriteLine(texto);
            texto = "Hola a todos";
            Console.WriteLine(texto);


            int x = 2;
            int y = 4;
            int res = x + y++;
            Console.WriteLine(res);
            string myVar1 = "Hello ";
            string myVar2 = "World!";
            Console.WriteLine(myVar1 + myVar2);
            x = 5;
            int w = 9;
            y = 2;
            int z = -3;
            int result = (w + x * z) / ++y;
            Console.WriteLine(result);
            result += 8 * x;
            Console.WriteLine(result);
            result *= 2;
            Console.WriteLine(result);
            float result2 = result / 0.5f;
            Console.WriteLine(result2);

            // Casting de variables
            int myInt = 4;
            float myFloat = 8.24f;
            double myDouble = 10.64;
            string myString = "84";
            myInt = (int)myFloat;
            myInt = (int)myDouble;
            myInt = Convert.ToInt32(myString);
            myFloat = myInt;
            myFloat = (float)Convert.ToDouble(myString);
            myFloat = (float)myDouble;
            myString = Convert.ToString(myInt);
            myString = Convert.ToString(myFloat);
            myString = Convert.ToString(myDouble);
            myDouble = myFloat;
            myDouble = myInt;
            myDouble = Convert.ToDouble(myString);

            Console.WriteLine(myInt + myFloat);
            Console.WriteLine(myInt + myString);
            Console.WriteLine(myInt + myDouble);
            Console.WriteLine(myFloat + myString);
            Console.WriteLine(myFloat + myDouble);
            Console.WriteLine(myString + myDouble);

            // Espaciado entre los dos programas
            Console.WriteLine(" ");

            // Programa nombres y edades
            /*
            Console.WriteLine("Tu nombre");
            string name1 = Console.ReadLine();
            Console.WriteLine("Tu edad");
            int edad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su nombre es " + name1);
            Console.WriteLine("Su edad es " + edad1);
            Console.WriteLine("Nombre de tu amigo");
            string name2 = Console.ReadLine();
            Console.WriteLine("Edad de tu amigo");
            int edad2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El nombre de tu amigo es " + name2);
            Console.WriteLine("La edad de tu amigo es " + edad2);
            Console.WriteLine("La diferencia de edad entre los dos es " + (edad1 - edad2));
            Console.WriteLine("La suma de vuestras edades es " + (edad1 + edad2));
            */

            // Programa para nota media

            /*Console.WriteLine("Nombre de asignatura 1:");
            string asign1 = Console.ReadLine();
            Console.WriteLine("La asignatura 1 es " + asign1);
            Console.WriteLine("Nota asignatura 1:");
            float nota1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("La nota de la asignatura 1 es " + nota1);
            Console.WriteLine("Nombre de asignatura 2:");
            string asign2 = Console.ReadLine();
            Console.WriteLine("La asignatura 2 es " + asign2);
            Console.WriteLine("Nota asignatura 2:");
            float nota2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("La nota de la asignatura 2 es " + nota2);
            Console.WriteLine("La nota media es " + ((nota1 + nota2) / 2));
            */

            // Espaciado entre los dos programas
            Console.WriteLine(" ");

            // Booleans
            /*
            bool result1 = (2 > 5 || 4 == 4 && 6 <= 7);
            Console.WriteLine(result1);
            Console.WriteLine("Escribe un número:");
            float numero1 = Convert.ToSingle(Console.ReadLine());
            bool result22 = (numero1 == 10);
            Console.WriteLine(result22);
            Console.WriteLine("Escribe otro número:");
            float numero2 = Convert.ToSingle(Console.ReadLine());
            bool result3 = !(numero2 == 5);
            Console.WriteLine(result3);
            Console.WriteLine("Escribe otro número:");
            float numero3 = Convert.ToSingle(Console.ReadLine());
            bool result4 = (numero3 != 5);
            Console.WriteLine(result4);
            
            Console.WriteLine("Escribe un número");
            float num = Convert.ToSingle(Console.ReadLine());
            if (num > 10)
            {
                Console.WriteLine("Es mayor que 10");
            }

            Console.WriteLine("Número 1:");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Número 2:");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Número 3:");
            float num3 = Convert.ToSingle(Console.ReadLine());
            if (num1 > 50 && num2 > 50 && num3 > 50)
            {
                Console.WriteLine("Muy grandes");
            }
            else if (num1 > 50 && num2 > 50 || num1 > 50 && num3 > 50 || num2 > 50 && num3 > 50)
            {
                Console.WriteLine("Dos grandes");
            }
            else if (num1 > 50 || num2 > 50 || num3 > 50)
            {
                Console.WriteLine("Solo un grande");
            }
            else
            {
                Console.WriteLine("Meh! muy pequeños");
            }
            
            // Menu de juego
            // Mostrar "elige una opción"
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1-Jugar");
            Console.WriteLine("2-Opciones");
            Console.WriteLine("3-Créditos");
            int decision = Convert.ToInt32(Console.ReadLine());
            switch (decision)
            {
                case 1:
                    Console.WriteLine("Estás jugando");
                    break;
                case 2:
                    Console.WriteLine("Estás en opciones");
                    break;
                case 3:
                    Console.WriteLine("Estás viendo los créditos");
                    break;
                default:
                    Console.WriteLine("No es una opción válida");
                    break;
            }
           

            //Menu de juego 2
            int decision2;
            do
            {
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("Presiona 1 para empezar a jugar");
                Console.WriteLine("Presiona 2 para ver las opciones");
                Console.WriteLine("Presiona 3 para ver los créditos");
                Console.WriteLine("Presiona 4 para salir");
                decision2 = Convert.ToInt32(Console.ReadLine());
                switch (decision2)
                {
                    case 1:
                        Console.WriteLine("Estás jugando");
                        break;
                    case 2:
                        Console.WriteLine("Estás en opciones");
                        break;
                    case 3:
                        Console.WriteLine("Estás viendo los créditos");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("No es una opción válida");
                        break;
                }
            }
            while (decision2 != 4);

            // Tabla hasta el 20
            Console.WriteLine("Escribe un número");
            int mynum = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            while(n<21)
            {
                Console.WriteLine(mynum + " por " + n + " es igual a " + mynum * n);
                ++n;
            }

            // Repetir texto
            Console.WriteLine("Escribe un texto");
            string inputTxt = Console.ReadLine();
            Console.WriteLine("Escribe el numero de veces que quieres que se repita el texto que has escrito");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            while (inputNum > 0)
            {
                Console.WriteLine(inputTxt);
                --inputNum;
            }
            

            // Juego Adivina el número
            Random myRandom = new Random();
            int RandomNum = myRandom.Next(0, 100);
            Console.WriteLine("Adivina el número entre 0 y 100");
            int ProbarNumero;
            do
            {
                ProbarNumero = Convert.ToInt32(Console.ReadLine());
                if (ProbarNumero > RandomNum)
                    Console.WriteLine("El número que has puesto es mayor");
                else if (ProbarNumero < RandomNum)
                    Console.WriteLine("El número que has puesto es menor");
                else
                    Console.WriteLine("Has acertado!");

            }
            while (ProbarNumero != RandomNum);
            

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
            while (segundos > 60)
            {
                segundos = segundos - 60;
                minutos = minutos + 1;
            }
            while (minutos > 60)
            {
                minutos = minutos - 60;
                horas = horas + 1;
            }
            while (horas > 24)
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
                switch(number)
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
            */
            

            // Calcular Factorial
            Console.WriteLine("Escribe un número para calcular su factorial");
            int numeroFac = Convert.ToInt32(Console.ReadLine());
            int aux = 1;
            int resultado3 = 1;
            while(aux<=numeroFac)
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
            int filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el número de columnas");
            int columnas = Convert.ToInt32(Console.ReadLine());
            string objeto = "X";
            string espacio = "  ";
            string tronco = objeto;
            for (int q = 1; q <= (columnas-2); ++q)
            {
                tronco = tronco + espacio;
            }
            tronco = tronco + " " + objeto;


            for (int i = 1; i <= columnas; ++i)
            {
                Console.Write(objeto + " ");
            }
            Console.WriteLine(" ");
            for (int i = 1; i <= (filas-2); ++i)
            {
                Console.WriteLine(tronco);
            }
            for (int i = 1; i <= columnas; ++i)
            {
                Console.Write(objeto + " ");
            }






            Console.ReadKey();
        }
    }
}

