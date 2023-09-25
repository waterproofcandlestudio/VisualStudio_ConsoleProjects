using System;

namespace ClienteGrupo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente_Chat Chat = new Cliente_Chat();
        }

        class Cliente_Chat
        {
            static private NetworkStream stream;
            static private StreamWriter streamw;
            static private StreamReader streamr;
            static private TcpClient client = new TcpClient();
            static private string nick = "unknown";
            static private int num = 1;

            public Cliente_Chat()
            {
                nick = "cliente " + num;
                Conectar();
            }
            // Método para escuchar lo que envía el servidor
            void Listen()
            {
                while (client.Connected)
                {
                    try
                    {
                        this.Invoke(new DaddItem(AddItem), streamr.ReadLine());
                    }
                    catch
                    {
                        MessageBox.Show("No se ha podido conectar al servidor");
                        Application.Exit();
                    }
                }
            }
            streamw.WriteLine(txtMensaje.Text);
                streamw.Flush();
                txtMensaje.Clear();
            // Método para conectar el cliente al servidor
            void Conectar()
            {

                try
                {
                    client.Connect("127.0.0.1", 8000);
                    if (client.Connected)
                    {
                        Thread t = new Thread(Listen);

                        stream = client.GetStream();
                        streamw = new StreamWriter(stream);
                        streamr = new StreamReader(stream);

                        streamw.WriteLine(nick);
                        streamw.Flush();

                        t.Start();
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
        }
    }
}