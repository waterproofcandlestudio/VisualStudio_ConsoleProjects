using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            Servidor_Chat Chat = new Servidor_Chat();
        }

        class Servidor_Chat
        {
            // Guardo la conexión
            private TcpListener server;
            private TcpClient client = new TcpClient();
            private IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 8000);
            private List<Conexion> list = new List<Conexion>();

            // Creo la variable para la conexión
            Conexion con;

            // Creación de una estructura para guardar los datos de cada cliente
            private struct Conexion
            {
                public NetworkStream stream;
                public StreamWriter streamw;
                public StreamReader streamr;
                public string nick;
            }
            // Constructor que llama al inicio
            public Servidor_Chat()
            {
                Inicio();
            }
            // Método Inicio para arrancar el servidor
            public void Inicio()
            {
                Console.WriteLine("Servidor Activado!");
                server = new TcpListener(ipendpoint);
                server.Start();

                // Bucle para crear una nueva conexión y rellenar los datos
                while (true)
                {
                    client = server.AcceptTcpClient();

                    con = new Conexion();
                    // Recupero los datos de la conexión del cliente 
                    con.stream = client.GetStream();
                    // Creo un streamreader con los datos de la conexión del cliente que recuperé en la linea anterior
                    con.streamr = new StreamReader(con.stream);
                    // Creo un streamwriter
                    con.streamw = new StreamWriter(con.stream);

                    // Recupero el nick del streamreader
                    con.nick = con.streamr.ReadLine();

                    // Añado el nuevo cliente a la lista de conexiones/clientes
                    list.Add(con);
                    Console.WriteLine(con.nick + " se a Conectado.");

                    // Creo un hilo para cada socket nuevo y lo inicializo
                    Thread t = new Thread(Escuchar_conexion);
                    t.Start();
                }
            }
            void Escuchar_conexion()
            {
                // Creo una estructura de tipo Conexion para poder trabajar con ella
                Conexion hcon = con;

                // Bucle para escuchar al cliente
                do
                {
                    try
                    {
                        // Leo el mensaje del cliente
                        string tmp = hcon.streamr.ReadLine();
                        // Escribo por pantalla en el servidor el "nick" y el msg guardado en "tmp"
                        Console.WriteLine(hcon.nick + ": " + tmp);
                        // Envio a todos los clientes el msg recibido

                        if (tmp == "salir")
                        {
                            list.Remove(hcon);
                            Console.WriteLine(con.nick + " se a Desconectado.");
                            break;
                        }
                        foreach (Conexion c in list)
                        {
                            if (c.nick != hcon.nick)
                            {
                                try
                                {
                                    c.streamw.WriteLine(hcon.nick + ": " + tmp);
                                    c.streamw.Flush();
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                    catch
                    {
                    }
                } while (true);
            }
        }
    }
}
