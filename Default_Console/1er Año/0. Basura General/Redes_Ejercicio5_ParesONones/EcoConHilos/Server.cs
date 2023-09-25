// Miguel Rodriguez Gallego

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Redes_Ejercicio5_ParesONones
{
    class Server
    {
        private const int listenPort = 12000; 

        public static void Main()
        {
            bool cerrarServer = false;
            int contadorClientes = 1;

            //Inicializamos el socket. Será un socket TCP
            Socket mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //Tenemos que decirle dónde se va a conectar este socket, 
            //en este caso al ser el servidor le metemos el IPAddress.Any
            //que quiere decir que el servidor escuchará en todas las interfaces
            //, y el puerto 1234

            IPEndPoint direccion = new IPEndPoint(IPAddress.Any, 12000);

            try
            {

                //Ahora que tenemos el socket y la dirección, tenemos que enlazarlos, para
                //eso usamos bind
                mySocket.Bind(direccion);
    
                //Lo ponemos en "modo escucha", y decimos que acepte solo 2 clientes de cada vez
                mySocket.Listen(2);

                //Aquí nos ponemos a "escuchar". Esto quiere decir que la ejecución de este programa se 
                //bloquea hasta que alguien se conecte al socket
                //Este método como ves, devuelve un socket que he llamado clientsocket. Este clientsocket
                //es el socket por el que escribiremos y leeremos del cliente. El socket mysocket solo lo usaremos
                //para recibir las peticiones de conexión
                Socket clientSocket = mySocket.Accept(); //<-- La ejecución se va a parar aquí hasta que alguien se conecte


                // Inicializo el socket del cliente 1
                Thread hiloCliente1 = new Thread(() => HiloCliente(clientSocket));

                hiloCliente1.Start();

                // Inicializo el socket del cliente 2
                Thread hiloCliente2 = new Thread(() => HiloCliente(clientSocket));

                hiloCliente2.Start();

                // Pares o nones
                for (int y = 1; y <= 5; y++)
                {
                    int rand = NumAleatorio();
                    string resultado;

                    if (rand % 2 == 0)
                    {
                        resultado = "par";
                    }
                    else
                    {
                        resultado = "non";
                    }

                    SendToSocket(clientSocket, "Selección Par o Non");
                    string textToReceive = ReadFromSocket(clientSocket);                   
                }


                //No cerramos el socket del servidor porq sino se cerraría el programa lol
                mySocket.Close();

            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }

            Console.WriteLine("Presione cualquier tecla para terminar");
            Console.ReadLine();

        }

        public static void HiloCliente(Socket clientSocket)
        {
            string textoRecibido;

            do
            {
                //El servidor se bloquea para esperar por un mensaje de la otra persona
                //Crear el array que recibe los bytes del cliente
                byte[] bytesToReceive = new byte[512];
                //Leo el socket y me lo guardo para saber cuantos bytes he recibido
                int bytesReceived = clientSocket.Receive(bytesToReceive, 0, bytesToReceive.Length, SocketFlags.None);
                //Corta el array sobrante
                Array.Resize(ref bytesToReceive, bytesReceived);
                //Pasamos el arrays de bytes a string para poder leerlo y lo mostramos por pantalla :D
                textoRecibido = Encoding.Default.GetString(bytesToReceive);

                string texToSend = string.Empty; 

                //Comprobar si el usuario quiere ver el historial de mensajes o no y mostrarselo
                Console.WriteLine("El mensaje del cliente es: " + textoRecibido);

                //Respondemos al cliente
                Console.WriteLine("Mensaje recibido");
                Console.WriteLine("Mensaje en mayúsuclas...");

                //Enviar los datos al cliente
                byte[] bytesToSend = Encoding.Default.GetBytes(texToSend);
                clientSocket.Send(bytesToSend, 0, bytesToSend.Length, SocketFlags.None);

                Thread.Sleep(500); 

            }
            while (textoRecibido != "salir");

            Console.WriteLine("El cliente ha cerrado la conexión");
            Console.Clear();
            clientSocket.Close();

        }
        // Convertir sockets
        static void SendToSocket(Socket socket, string textToSend)
        {
            byte[] bytesToSend = Encoding.Default.GetBytes(textToSend);
            socket.Send(bytesToSend);
        }
        static string ReadFromSocket(Socket socket)
        {
            byte[] bytesToReceive = new byte[512];
            int bytesReceived = socket.Receive(bytesToReceive, 0, bytesToReceive.Length, SocketFlags.None);
            Array.Resize(ref bytesToReceive, bytesReceived);
            return Encoding.Default.GetString(bytesToReceive);
        }

        // Creo los números aleatorios
        private static int NumAleatorio()
        {
            Random rnd = new Random();

            int randNum = rnd.Next(0,10);

            return randNum;
        }

    }
}
