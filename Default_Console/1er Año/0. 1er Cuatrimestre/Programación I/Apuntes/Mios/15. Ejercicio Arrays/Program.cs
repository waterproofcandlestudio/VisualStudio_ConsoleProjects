using System;

namespace Ejercicio_Arrays
{
    class Program
    {
        //Ejercicios Arrays

        static void Main(string[] args)
        {
            string num;
            string numRev;
            Console.WriteLine("Introduzca el número de letra que quiere añadir");
            num = StringRevert(num);

            if(num == numRev)
            {
                Console.WriteLine("Es capicúa");
            }
            else
            {
                Console.WriteLine("No es capicúa");
            }

            //Invierte unacadena de caracteres
            static string StringRevert(string array)
            {
                string finalText = "";

                for (int aux = array.Length - 1; aux >= 0; aux--)
                {
                    finalText += array[aux];
                }

                return finalText;
            }

            /*
            int input;
            bool salir = false;
            string finalText = "";
            char[] myAToZArray = ArrayGenerateAToZ();

            while(!salir)
            {
                Console.WriteLine("Introduzca el número de letra que quiere añadir");
                input = Convert.ToInt32(Console.ReadLine());
                while (input < -1 || input > myAToZArray.Length - 1)
                {
                    Console.WriteLine("Valor inválido. Introduzca el número de letra que quiere añadir");
                    input = Convert.ToInt32(Console.ReadLine());
                }

                if (input == -1)
                {
                    salir = true;
                }
                else
                {
                    finalText += myAToZArray[input];
                }

                Console.WriteLine(finalText);
            }
            */

        }

        //GEnera un array de 26 elementos con valores de A a Z
        static char[] ArrayGenerateAToZ()
        {
            char[] myAToZArray = new char[26];
            for(int aux = 0; aux < myAToZArray.Length; aux++)
            {
                if (aux < 14)
                {
                    myAToZArray[aux] = (char)(aux + 65);
                }
                else if(aux == 14)
                {
                    myAToZArray[aux] = 'Ñ';
                }
                else
                {
                    myAToZArray[aux] = (char)()
                }

            }
            return myAToZArray;
        }

        //Genera un array de 100 elementos con valores de 1 a 100
        static int[] ArrayGenerate1To100()
        {
            int[] result = new int[100];
            for(int aux = 0; aux < result.Length; aux++)
            {
                result[aux] = aux + 1;
            }

            return result;
        }

        //Calcula el valor medio del array
        static int[] ArrayAverage(int[] array)
        {
            int sumaTotal = ArrayTotal(array);
            return sumaTotal / array.Length;
        }

        //Genera un array con el tamaño especificado
        static int[] InitializeArray()
        {
            int[] result;
            Console.WriteLine("Escribe el tamaño del array");
            result = new int[Convert.ToInt32(Console.ReadLine())];
            return result;
        }

        //Rellena un array con valores aleatorios entre "x" e "y"
        static void FillArray(ref int[] array, int x, int y)
        {
            Random rnd = new Random();
            for(int aux = 0; aux)
        }

        //Suma cada valor del array
        static int ArrayTotal(int[]array)
        {
            int result=0
        }
        static int[] ArrayInput(int[]array)
        {
            for(int aux = 0; aux < array.Length; aux++)
            {
                Console.WriteLine("Escribe un número para insertar en el array");
                array[aux] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void ArrayShow(int[] array)
        {
            for (int aux = 0; aux < array.Length; aux++)
            {
                Console.WriteLine("Índice: " + aux + "\t")
            }
        }

        static int ArrayMaxValue(int[]array)
        {
            int result = array[0];
            for (int aux = 0; aux < array.Length; aux++)
            {

            }
        }

        static int ArrayOrder(ref int[] array)
        {
            for (int aux = 0; aux < array.Length; aux++)
            {
                for (int aux2 = aux + 1; aux2 < array.Length; aux2++)
                {
                    if(array[aux]< array[aux2])
                    {
                        int temp = array[aux];
                        array[aux] = array[aux2];
                        array[aux2] = temp;
                    }
                }
            }
        }
    }
}
