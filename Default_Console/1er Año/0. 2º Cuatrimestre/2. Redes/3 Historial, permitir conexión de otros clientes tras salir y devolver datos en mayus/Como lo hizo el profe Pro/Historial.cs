using System.Collections.Generic;
using System.Text;

namespace SocketServerTCP
{
    public class Historial
    {
        protected List<string> messages;

        public Historial()
        {
            messages = new List<string>();
        }

        public string ProcesarMensaje(string msg)
        {
            messages.Add(msg);

            if (msg == "historial")
            {
                return GetHistorial();
            }
            else
            {
                return msg.ToUpper();
            }
        }

        public string GetHistorial()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < messages.Count; i++)
            {
                sb.AppendLine(messages[i]);
            }
            return sb.ToString();
        }
    }
}