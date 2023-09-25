using System;

namespace OperacionesconStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "holamellamojuan";
            for (int i = 0; i < myString.Length; ++i) 
            { 
                Console.Write(myString[i] + " ");
            }
            Console.WriteLine("");

            Console.WriteLine(myString.Length);

            for (int i = myString.Length - 1; i >= 0; --i)
            {
                Console.Write(myString[i]);
            }

            Console.WriteLine(myString.Replace("juego", "videojuego"));

            string cifrado = "";
            for (int aux = 0; aux < myString.Length; aux++)
            {
                if(myString[aux] == ' ')
                {
                    cifrado += ' ';
                }
                else
                {
                    int ascii = Convert.ToInt32(myString[aux]);
                    ascii++;
                    cifrado += (char)ascii;
                }
                Console.Write(cifrado);
            }
        }
    }
}
