using System;
using System.Threading;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            Change(ref value);

            int testOut;
            Set10(out testOut);

            Console.WriteLine(value);

        }

        static int Set10(out int x)
        {
            int res;
            x = 10;

            return res;
        }

        static void Change(ref int x)
        {

        }
    }
}
