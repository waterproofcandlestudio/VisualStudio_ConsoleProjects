﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Redes_Ejercicio5_ParesONones
{
    internal class Client
    {
        private static void Main(string[] args)
        {
            //Los tres primeros pasos son iguales que para el servidor, creamos un socket
            //elegimos una dirección y enlazamos el socket. La dirección es la misma.
            Socket mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12000);

            try
            {
                Console.WriteLine("Intentando conexión...");
                mySocket.Connect(direccion);

                bool connected = true;

                while (connected)
                {
                    Console.WriteLine("Conectado. Introduce algo para mandar al servidor: ");
                    var textToSend = Console.ReadLine();
                    if (textToSend == "salir")
                    {
                        connected = false;
                    }

                    //1 - pasar a bytes
                    byte[] bytesToSend = Encoding.Default.GetBytes(textToSend);
                    //2 - enviamos los datos
                    mySocket.Send(bytesToSend, 0, bytesToSend.Length, SocketFlags.None);

                    //recibo el ok
                    byte[] bytesToReceive = new byte[512];
                    int receivedBytes = mySocket.Receive(bytesToReceive, 0, bytesToReceive.Length, SocketFlags.None);
                    Array.Resize(ref bytesToReceive, receivedBytes);
                    string serverMessageAsString = Encoding.Default.GetString(bytesToReceive);

                    Console.WriteLine("Recibida respuesta del servidor: " + serverMessageAsString);
                }

                mySocket.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }
            Console.WriteLine("Presione cualquier tecla para terminar");
            Console.ReadLine();
        }
    }
}