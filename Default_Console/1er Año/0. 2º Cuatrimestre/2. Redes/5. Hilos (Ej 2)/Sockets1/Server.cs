using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SocketServerTCP
{
    internal class Server
    {
        public static void Main()
        {
            //Inicializamos el socket. Será un socket TCP
            Socket mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //Tenemos que decirle dónde se va a conectar este socket,
            //en este caso al ser el servidor le metemos el IPAddress.Any
            //que quiere decir que el servidor escuchará en todas las interfaces
            //, y el puerto 1234
            IPEndPoint direccion = new IPEndPoint(IPAddress.Any, 1234);

            Historial h = new Historial();

            try
            {
                //Ahora que tenemos el socket y la dirección, tenemos que enlazarlos, para
                //eso usamos bind
                mySocket.Bind(direccion);

                //Lo ponemos en "modo escucha", y decimos que acepte solo 1 cliente de cada vez
                mySocket.Listen(1);

                Console.WriteLine("Servidor Escuchando...");

                while (true)
                {
                    Socket clientSocket = mySocket.Accept(); //<-- La ejecución se va a parar aquí hasta que alguien se conecte

                    Console.WriteLine("Alguien se ha conectado! ");

                    bool connected = true;

                    while (connected)
                    {
                        //recibo datos
                        byte[] bytesToReceive = new byte[512];
                        int bytesReceived = clientSocket.Receive(bytesToReceive, 0, bytesToReceive.Length, SocketFlags.None);
                        Array.Resize(ref bytesToReceive, bytesReceived);
                        string textoRecibido = Encoding.Default.GetString(bytesToReceive);

                        if (textoRecibido == "salir")
                            connected = false;

                        //envío ok
                        Console.WriteLine("He recibido del cliente: " + textoRecibido);
                        byte[] okMessage = Encoding.Default.GetBytes(textoRecibido.ToUpper());//<-nuevo
                        clientSocket.Send(okMessage, 0, okMessage.Length, SocketFlags.None);
                    }

                    Console.WriteLine("Cliente desconectado! ");
                    clientSocket.Close();
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