//Martin Perez Villabrille

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace EcoConHilos
{
    class Server
    {
        private const int listenPort = 12000; 

        public static void Main()
        {
            bool cerrarServer = false;
            int contadorClientes = 1;

            Historial historial = new Historial();
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

                //Con este bucle hacemos que el servidor se quede escuchando hasta que llegue otro cliente todo el rato

                do
                {

                //Lo ponemos en "modo escucha", y decimos que acepte solo 1 cliente de cada vez
                mySocket.Listen(1);

                Console.WriteLine("Servidor escuchando por un cliente...");

                //Aquí nos ponemos a "escuchar". Esto quiere decir que la ejecución de este programa se 
                //bloquea hasta que alguien se conecte al socket
                //Este método como ves, devuelve un socket que he llamado clientsocket. Este clientsocket
                //es el socket por el que escribiremos y leeremos del cliente. El socket mysocket solo lo usaremos
                //para recibir las peticiones de conexión
                    Socket clientSocket = mySocket.Accept(); //<-- La ejecución se va a parar aquí hasta que alguien se conecte

                    Thread hiloClientes = new Thread(() => HiloCliente(clientSocket, historial));

                    hiloClientes.Start(); 

                    Console.WriteLine("El cliente número " + contadorClientes);
                    Console.WriteLine("El cliente te contactará ahora... ");

                    contadorClientes++;

                } while (cerrarServer == false) ;

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

        public static void HiloCliente(Socket clientSocket, Historial historial)
        {
            string textoRecibido;

            do
            {
                //Esperamos a recibir el mensaje del cliente

                //El servidor se bloquea para esperar por un mensaje de la otra persona
                //Crear el array que recibe los bytes del cliente
                byte[] bytesToReceive = new byte[512];
                //Leo el socet y me lo guardo para saber cuantos bytes he recibido
                int bytesReceived = clientSocket.Receive(bytesToReceive, 0, bytesToReceive.Length, SocketFlags.None);
                //Corta el array sobrante
                Array.Resize(ref bytesToReceive, bytesReceived);
                //Pasamos el arrays de bytes a string para poder leerlo y lo mostramos por pantalla :D
                textoRecibido = Encoding.Default.GetString(bytesToReceive);

                string texToSend = string.Empty; 

                lock (historial)
                {
                    //Cuando entra aquí estoy seguro de que soy el único que está usando el historial en este momento
                    if (textoRecibido != "historial")
                    {
                        texToSend = historial.procesarMensaje(textoRecibido).ToString(); 
                    }
                }

                //Comprobar si el usuario quiere ver el historial de mensajes o no y mostrarselo
                Console.WriteLine("El mensaje del cliente es: " + textoRecibido);

                    //Respondemos al cliente

                Console.WriteLine("Mensaje recibido");
                Console.WriteLine("Mensaje en mayúsuclas...");
                //Pillar el texto que se quiera mandar y convertirlo en bytes para mandar. 

                if (textoRecibido == "historial")
                {
                    //Enviar los datos al cliente
                    historial.MostrarHistorial();
                }
                else
                {
                    //Enviar los datos al cliente
                    byte[] bytesToSend = Encoding.Default.GetBytes(texToSend);
                    clientSocket.Send(bytesToSend, 0, bytesToSend.Length, SocketFlags.None);
                }

                Thread.Sleep(500); 

            }
            while (textoRecibido != "salir");

            Console.WriteLine("El cliente ha cerrado la conexión");
            Console.Clear();
            clientSocket.Close();

        }
    }
}
