using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using SocketsServer;

namespace SocketServerTCP
{
    class Server
    {

        private const int listenPort = 11000;
        public static void Main()
        {
            //Inicializamos el socket. Será un socket TCP
            Socket mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //Tenemos que decirle dónde se va a conectar este socket, 
            //en este caso al ser el servidor le metemos el IPAddress.Any
            //que quiere decir que el servidor escuchará en todas las interfaces
            //, y el puerto 1234
            IPEndPoint direccion = new IPEndPoint(IPAddress.Any, 1234);

            try
            {
                //Ahora que tenemos el socket y la dirección, tenemos que enlazarlos, para
                //eso usamos bind
                mySocket.Bind(direccion);

                //Lo ponemos en "modo escucha", y decimos que acepte solo 1 cliente de cada vez
                mySocket.Listen(1);

                Console.WriteLine("Servidor Escuchando...");

                // Hago un bucle para que el servidor acepte + d 1 cliente
                while (true)
                {
                    //Aquí nos ponemos a "escuchar". Esto quiere decir que la ejecución de este programa se 
                    //bloquea hasta que alguien se conecte al socket
                    //Este método como ves, devuelve un socket que he llamado clientsocket. Este clientsocket
                    //es el socket por el que escribiremos y leeremos del cliente. El socket mysocket solo lo usaremos
                    //para recibir las peticiones de conexión
                    Socket clientSocket = mySocket.Accept(); //<-- La ejecución se va a parar aquí hasta que alguien se conecte
                    Console.WriteLine("Alguien se ha conectado!");
                    // Creo el array donde almacenaré lo que lea
                
                    string textoRecibido = " ";

                    // Creo un objeto Historial
                    Historial hist = new Historial();

                    while (textoRecibido != "exit")
                    {
                        byte[] bytesToRecieve = new byte[512];
                        // Leo del socket y me guardo en bytesReceived cuantos bytes he recibido
                        int bytesReceived = clientSocket.Receive(bytesToRecieve);
                        // Corto del array lo que sobra
                        Array.Resize(ref bytesToRecieve, bytesReceived);
                        // Paso el array de bytes a string
                        textoRecibido = Encoding.Default.GetString(bytesToRecieve);

                        string[] msg = new string[512];
                        msg = hist.procesarMensaje(textoRecibido);


                        byte[] okMessage = Encoding.Default.GetBytes("Recibido");
                        clientSocket.Send(okMessage);
                    }
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
