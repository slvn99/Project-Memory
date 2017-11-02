using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    class ServerClient
    {
        static int PacketSize = 1024 * 1024;
        public static TcpClient Client; //client die geconnect is
        //IPAddress ipAddress = "141.252.225.177";
        //IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 8984);
        public static List<Point> TempRandomButLocation = new List<Point>();

        public static void StartClient()
        {
            try
            {
                Client = new TcpClient("141.252.225.177", 8984);

            }
            catch
            {
                MessageBox.Show("ERROR, er kon geen verbinding gemaakt worden!", "ERROR!", MessageBoxButtons.OK);
            }

            //Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //My_Socket.BeginConnect(localEndPoint, new AsyncCallback(Connect_To_Port), My_Socket);

        }

        public static void RecieveGamaData()
        {
            var bin = new BinaryFormatter();
            var list = (List<Point>)bin.Deserialize(Client.GetStream());
            TempRandomButLocation = list;
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