﻿using System;
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

namespace Memory
{
    class ServerHost
    {
        static int PacketSize = 1024 * 1024;
        public static TcpListener Listener;
        public static TcpClient Client; //client die geconnect is
        public static List<Point> TempRandomButLocation = new List<Point>();
        public static Button tempGridbutton = new Button();

        public static void StartServer()
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 8984);
            Listener = new TcpListener(ip);
            Listener.Start();
            AcceptClient();
        }

        public static void AcceptClient()
        {
            Listener.BeginAcceptTcpClient(ClientConnected, null);
            GameServer.TempConLabel.Text = "connecting";
        }

        public static void ClientConnected(IAsyncResult ar)
        {
            Client = Listener.EndAcceptTcpClient(ar);
        }

        public static void SendGameState()
        {
            TempRandomButLocation = GameServer.RandomButLocation;
            var bin = new BinaryFormatter();
            bin.Serialize(Client.GetStream(), TempRandomButLocation);
        }

        public static bool SendMessage(string message)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                Client.GetStream().Write(bytes, 0, bytes.Length); // Send the response
                return true;
            }
            catch (Exception)
            {
                Client.Close();
                return false;
            }
        }

        public static string ReceiveMessage()
        {
            try
            {
                byte[] buffer = new byte[PacketSize];
                Client.GetStream().Read(buffer, 0, PacketSize);
                string message = cleanMessage(buffer);
                if (message == null)
                {
                    Client.Close();
                    return null;
                }
                return message;
            }
            catch (Exception)
            {
                Client.Close();
                return null;
            }
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
