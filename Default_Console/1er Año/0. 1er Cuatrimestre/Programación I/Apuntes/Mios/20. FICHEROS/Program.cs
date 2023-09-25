using System;
using System.IO;

namespace _20._FICHEROS
{
    class Program
    {
        static void Main(string[] args)
        {
            int linea;
            StreamWriter file;
            StreamReader ficheroDeLectura;

            ficheroDeLectura = File.OpenText("partidaGuardada.txt");
            file = File.CreateText("partidaGuardada.txt");

            linea = Convert.ToInt32(ficheroDeLectura.ReadLine());

            ficheroDeLectura.Close();

            if(linea == 0)
            {

            }
        }
    }
}
