using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_Client
{
    class Program
    {
        private static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        static void Main(string[] args)
        {
            Console.Title = "Client";
            LoopConnect();
            SendLoop();
            Console.ReadLine();
        }

        private static void SendLoop()
        {
            while (true)
            {
                Console.WriteLine("Enter a request");
                string req = Console.ReadLine();
                byte[] buffer = Encoding.ASCII.GetBytes(req);
                clientSocket.Send(buffer);

                byte[] receivedBuffer = new byte[1024];
                int recData = clientSocket.Receive(receivedBuffer);
                byte[] data = new byte[recData];
                Array.Copy(receivedBuffer, data, recData);
                Console.WriteLine("Received: " + Encoding.ASCII.GetString(data));
            }
        }

        private static void LoopConnect()
        {
            int attempts = 0;

            while (!clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    clientSocket.Connect(IPAddress.Loopback, 500);
                }
                catch (SocketException)
                {
                    Console.Clear();
                    Console.WriteLine("Connection attempts: " + attempts.ToString());
                }
            }
            Console.Clear();
            Console.WriteLine("Connected");
        }
    }
}
