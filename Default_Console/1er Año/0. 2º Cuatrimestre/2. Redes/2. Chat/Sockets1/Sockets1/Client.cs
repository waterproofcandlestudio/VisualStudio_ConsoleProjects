using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SocketClientTCP
{
    class Client
    {
        static void Main(string[] args)
        {
            //Los tres primeros pasos son iguales que para el servidor, creamos un socket
            //elegimos una dirección y enlazamos el socket. La dirección es la misma.
            Socket mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

            try
            {
                Console.WriteLine("Intentando conexión...");
                mySocket.Connect(direccion);

                Console.WriteLine("Conectado. Introduce algo para mandar al servidor: ");

                var textToSend = " ";
                while (textToSend != "exit")
                {
                    textToSend = Console.ReadLine();
                    //1 - Pasar a bytes
                    byte[] bytesToSend = Encoding.Default.GetBytes(textToSend);
                    // 2 - Enviamos el ok
                    mySocket.Send(bytesToSend);
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
