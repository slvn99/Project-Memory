using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class ServerClient
    {
        static int PacketSize = 1024 * 1024;
        public static TcpClient Client; //client die geconnect is

        public static void StartClient()
        {
            Client = new TcpClient("141.252.225.170", 8984);
        }

        public static void SendMessage(string message)
        {
            //Send message
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            NetworkStream stream = Client.GetStream();
            stream.Write(bytes, 0, bytes.Length);
        }

        public static string ReceiveMessage()
        {
            byte[] bytes = new byte[PacketSize];
            NetworkStream stream = Client.GetStream();
            stream.Read(bytes, 0, PacketSize);
            return cleanMessage(bytes);
        }
        private static string cleanMessage(byte[] bytes)
        {
            string message = Encoding.UTF8.GetString(bytes);

            string messageToPrint = null;
            foreach (var nullChar in message)
            {
                if (nullChar != '\0')
                {
                    messageToPrint += nullChar;
                }
            }
            return messageToPrint;
        }
    }
}