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
        public static string HostIP, HostName;
        public static bool ClientConnection;
        static int PacketSize = 1024 * 1024;
        public static TcpClient Client;
        public static List<Point> TempRandomButLocation = new List<Point>();
        public static string[] TurnArray = new string[1];

        public static void StartClient()
        {
            try
            {
                Client = new TcpClient(HostIP, 8984);
                ClientConnection = true;
            }
            catch
            {
                MessageBox.Show("Error, het was niet mogenlijk om connectie te maken.", "ERROR!", MessageBoxButtons.OK);
                ClientConnection = false;
            }
        }

        public static void RecieveGamaData()
        {
            var bin = new BinaryFormatter();
            var list = (List<Point>)bin.Deserialize(Client.GetStream());
            TempRandomButLocation = list;
        }

        public static void SendTurn()
        {
            TurnArray = GameServer.TurnArray;
            var bin = new BinaryFormatter();
            bin.Serialize(Client.GetStream(), TurnArray);
        }

        public static void RecieveTurn()
        {
            var bin = new BinaryFormatter();
            TurnArray =(string[])bin.Deserialize(Client.GetStream());
        }

        public static void SendName()
        {
            var bin = new BinaryFormatter();
            bin.Serialize(Client.GetStream(), GameServer.LocalPlayer);
        }

        public static void RecieveName()
        {
            var bin = new BinaryFormatter();
            HostName = (string) bin.Deserialize(Client.GetStream());
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