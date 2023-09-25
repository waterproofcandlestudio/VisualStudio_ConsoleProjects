using System;

namespace Clase_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //CLASE 5 (BORRADOR)


            // Control de flujo - SWITCH    


            /* EXPLICACIÓN

            int myint = 3;
            switch (myint)
            {
                case 0:

                    Console.WriteLine("user has typed 0");
                    break;

                case 1
                :

                    Console.WriteLine("user has typed 1");
                    break;

                case 2:

                    Console.WriteLine("user has typed 2");
                    break;


            }

            */


            // EJERCICIO

            int P;

            Console.WriteLine("introduce un número");
            P = Convert.ToInt32(Console.ReadLine());
            

            switch (P)
            {
                case 0:

                    Console.WriteLine("Jugar");
                    break;

                case 1:

                    Console.WriteLine("Multijugador");
                    break;

                case 2:

                    Console.WriteLine("Opciones");
                    break;

                case 3:

                    Console.WriteLine("Idioma");
                        break;

                case 4:

                    Console.WriteLine("Salir");
                    break
            }



            // Control de Flujo - OPERADOR TERNARIO


            int myage = 19;
            Console.WriteLine(myage >= 19);




            // Control de Flujo - BUCLE "Do While"


            int x = 0;
            do
            {
                Console.WriteLine("Continuamos el bucle");
                Console.WriteLine("Terminamos el bucle");
                // aqui falta una cosa al final

            }



            /* cosas de clase

             int number = -1;
             bool correctnumber = true;
             do
            
            */

            
            // Control de flujo - Bucle "For"

            // For (rar comprobación, expresión comparación, ejecución final)










        }
    }
}
