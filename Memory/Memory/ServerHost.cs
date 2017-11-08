using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

/// <summary>
/// Class die alle Game elementen uitvoert wanneer in gameserver.cs "Host" wordt geselecteerd
/// </summary>
namespace Memory
{
    class ServerHost
    {
        public static int counter = 0;
        public static string ClientName;
        public static TcpListener Listener;
        public static TcpClient Client; //client die geconnect is
        public static List<Point> TempRandomButLocation = new List<Point>();
        public static string[] TurnArray = new string[2];

        public static void StartServer()
        {
            if (counter == 0)
            {
                counter++;
                IPEndPoint ip = new IPEndPoint(IPAddress.Any, 8984);
                Listener = new TcpListener(ip);
                Listener.Start();
                AcceptClient();
            }
        }

        public static void AcceptClient()
        {
            Listener.BeginAcceptTcpClient(ClientConnected, null);
        }

        public static void ClientConnected(IAsyncResult ar)
        {
            try
            {
                Client = Listener.EndAcceptTcpClient(ar);
                GameServer.Connectie = true;
            }
            catch
            {
            }
        }

        public static void SendGameState()
        {
            try
            {
                TempRandomButLocation = GameServer.RandomButLocation;
                var bin = new BinaryFormatter();
                bin.Serialize(Client.GetStream(), TempRandomButLocation);
            }
            catch
            {
                MessageBox.Show("Error, Connectie verloren!", "ERROR!", MessageBoxButtons.OK);
                Listener.Stop();
                Client.Close();
                GameServer obj = (GameServer)Application.OpenForms["GameServer"];
                obj.Close();
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
                Listener.Stop();
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
                ClientName = (string)bin.Deserialize(Client.GetStream());
            }
            catch
            {
                MessageBox.Show("Error, Connectie verloren!", "ERROR!", MessageBoxButtons.OK);
                Listener.Stop();
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
                Listener.Stop();
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
                Listener.Stop();
                Client.Close();
                GameServer.Connectionfail = true;
            }
        }
    }
}
