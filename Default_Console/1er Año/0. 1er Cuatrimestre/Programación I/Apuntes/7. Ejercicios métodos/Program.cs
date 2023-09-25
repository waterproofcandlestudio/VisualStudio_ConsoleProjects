using System;

namespace _7._Ejercicios_métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios métodos

            // 1 ; Cuadrado

            static void Main(string[] args)
            {

                int inputNum;
                int resultado;

                Console.WriteLine("Dame un número");
                inputNum = Convert.ToInt32(Console.ReadLine());

                resultado = Cuadrado(inputNum);
                // Los parentesis definen las variables

                Console.WriteLine(resultado);
            }


            // Método que calcula el cuadrado de un número "num"
            static int Cuadrado(int num)
            //InputNum cambia a num porque es otra variable nueva la cual recibirá el valor de la que estaba entre parentesis(inputNum)
            {
                return num * num;
            }



            // 2; Potencias

            static void Main(string[] args)
            {

                int inputNum;
                int potencia;

                Console.WriteLine("Dame un número x");
                inputNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dame un número y");
                potencia = Convert.ToInt32(Console.ReadLine());

                elevado(inputNum, potencia);

            }

            static int elevado(int x, int y)
            {
                int res = 0;

                for (int aux = 0; aux < y; aux++)   // 0, 1 y 2
                {
                    res *= x; // res = res * x;
                }

                return res;
            }
        }
    }
}
