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
        public static TcpClient Client;
        public static List<Point> TempRandomButLocation = new List<Point>();
        public static string[] TurnArray = new string[2];

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
            try
            {
                var bin = new BinaryFormatter();
                var list = (List<Point>)bin.Deserialize(Client.GetStream());
                TempRandomButLocation = list;
            }
            catch
            {
                MessageBox.Show("Error, Connectie verloren!", "ERROR!", MessageBoxButtons.OK);
                Client.Close();
                GameServer obj = (GameServer)Application.OpenForms["GameServer"];
                obj.Close();
                GameServer.Connectionfail = true;
            }
        }

        public static void SendTurn()
        {
            try
            {
                TurnArray = GameServer.TurnArray;
                var bin = new BinaryFormatter();
                bin.Serialize(Client.GetStream(), TurnArray);
            }
            catch
            {
                MessageBox.Show("Error, Connectie verloren!", "ERROR!", MessageBoxButtons.OK);
                Client.Close();
                GameServer obj = (GameServer)Application.OpenForms["GameServer"];
                obj.Close();
                GameServer.Connectionfail = true;
            }
        }

        public static void RecieveTurn()
        {
            try
            {
                var bin = new BinaryFormatter();
                TurnArray = (string[])bin.Deserialize(Client.GetStream());
            }
            catch
            {
                MessageBox.Show("Error, Connectie verloren!", "ERROR!", MessageBoxButtons.OK);
                Client.Close();
                GameServer.Connectionfail = true;
            }
        }

        public static void SendName()
        {
            try
            {
                var bin = new BinaryFormatter();
                bin.Serialize(Client.GetStream(), GameServer.LocalPlayer);
            }
            catch
            {
                MessageBox.Show("Error, Connectie verloren!", "ERROR!", MessageBoxButtons.OK);
                Client.Close();
                GameServer obj = (GameServer)Application.OpenForms["GameServer"];
                obj.Close();
                GameServer.Connectionfail = true;
            }
        }

        public static void RecieveName()
        {
            try
            {
                var bin = new BinaryFormatter();
                HostName = (string)bin.Deserialize(Client.GetStream());
            }
            catch
            {
                MessageBox.Show("Error, Connectie verloren!", "ERROR!", MessageBoxButtons.OK);
                Client.Close();
                GameServer obj = (GameServer)Application.OpenForms["GameServer"];
                obj.Close();
                GameServer.Connectionfail = true;
            }
        }
    }
}