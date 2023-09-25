// Miguel Rodríguez Gallego

using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente_Chat Chat = new Cliente_Chat();
        }

        class Cliente_Chat
        {
            private NetworkStream stream;
            private StreamWriter streamw;
            private StreamReader streamr;
            private TcpClient client = new TcpClient();
            private string nick = "unknown";           

            public Cliente_Chat()
            {
                Conectar();
            }
     
            // Método para conectar el cliente al servidor
            void Conectar()
            {
                try
                {
                    client.Connect("127.0.0.1", 8000);
                    if (client.Connected)
                    {                       
                        stream = client.GetStream();
                        streamw = new StreamWriter(stream);
                        streamr = new StreamReader(stream);

                        Console.WriteLine("Introduzca el nick ");
                        Console.Write(">: ");
                        nick = Console.ReadLine();
                        streamw.WriteLine(nick);
                        streamw.Flush();

                        Thread t = new Thread(o => ReceiveData((TcpClient)o));
                        Console.Write(">: ");
                        t.Start(client);

                        string s;
                        //while (!string.IsNullOrEmpty((s = Console.ReadLine())))
                        while ((s = Console.ReadLine()) != "exit")
                        {
                            streamw.WriteLine(s);
                            Console.Write(">: ");
                            streamw.Flush();
                        }

                        client.Client.Shutdown(SocketShutdown.Send);
                        t.Join();
                        stream.Close();
                        client.Close();
                        Console.WriteLine("Se ha desconectado del servidor!!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Servidor no Disponible");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Servidor no Disponible");
                }
            }

            static void ReceiveData(TcpClient client)
            {
                NetworkStream ns = client.GetStream();                
                StreamReader sr = new StreamReader(ns);
                string tmp;              

                while ((tmp = sr.ReadLine()).Length > 0)
                {
                    Console.WriteLine(tmp);
                    Console.Write(">: ");
                }
            }   
        }
    }
}
