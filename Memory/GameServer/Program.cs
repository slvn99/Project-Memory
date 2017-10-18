using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    class Program
    {
        private static byte[] buffer = new byte[1024];
        private static List<Socket> clientSockets = new List<Socket>(); //list van clients die de server moet verwerken.
        private static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        static void Main(string[] args)
        {
            Console.Title = "Memory Server";
            SetupServer();
            Console.ReadLine();
        }

        private static void SetupServer()
        {
            Console.WriteLine("Setting up server....");
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 9899)); //bind serverSocet aan elk beschikbaar local interfaces
            serverSocket.Listen(2); // hoeveel pending connections de server aan kan.
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null); //kijkt of er connections pending zijn.

        }

        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = serverSocket.EndAccept(AR); //connect de socket aan de server.
            clientSockets.Add(socket); //add de geconecte socket to client list.
            Console.WriteLine("Client Connected");
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null); //kijkt of er connections pending zijn.
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int dataReceived = socket.EndReceive(AR);
            byte[] dataBuff = new byte[dataReceived];
            Array.Copy(buffer, dataBuff, dataReceived); //kopieert buffer naar dataBuff met de lengte van dataReceived.
            string text = Encoding.ASCII.GetString(dataBuff);
            Console.WriteLine("Text received: " + text);

            string response = string.Empty;

            if(text.ToLower() != "get time")
            {
                response = "Invalid Request";
            }
            else
            {
                response = DateTime.Now.ToLongTimeString();
            }

            byte[] data = Encoding.ASCII.GetBytes(response);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }

        private static void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }
    }
}
