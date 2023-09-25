using System;

namespace PRUEBA_4
{
    class Program
    {

        // 3 ; Calculadora

        static void Main(string[] args)
        {
            int op1;
            int op2;
            int numasum;
            int operacion;


            Console.WriteLine("Dime 1 operador");
            op1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime 1 operador");
            op2 = Convert.ToInt32(Console.ReadLine());


            do
            {
                Console.WriteLine("Presiona 1 para sumar");
                Console.WriteLine("Presiona 2 para restar");
                Console.WriteLine("Presiona 3 para multiplicar");
                Console.WriteLine("Presiona 4 dividir");

                Console.WriteLine("Que operación vas a hacer?");
                operacion = Convert.ToInt32(Console.ReadLine());

                switch (operacion)
                {
                    case 0:
                        Console.WriteLine("Entrada inválida");
                        break;

                    case 1:
                        sumar(op1, op2);
                        break;

                    case 2:
                        restar(op1, op2);
                        break;

                    case 3:
                        multiplicar(op1, op2);
                        break;

                    case 4:
                        dividir(op1, op2);
                        break;

                }
            } 
            while (operacion != 4);



        }

        static int sumar(int x, int y)
        {
            int res;
            res = x + y;
            return res;
        }

        static int restar(int x, int y)
        {
            int res;
            res = x - y;
            return res;
        }

        static int multiplicar(int x, int y)
        {
            int res;
            res = x * y;
            return res;
        }

        static int dividir(int x, int y)
        {
            int res;
            res = x / y;
            return res;
        }

    }
}
