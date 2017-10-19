using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SERVER of CLIENT");
            string keuze = Console.ReadLine();
            if (keuze == "SERVER")
            {
                MemoryServer.StartServer();
                Console.WriteLine(MemoryServer.ReceiveMessage());
            }
            
            else
            {
                MemoryClient.StartClient();
                MemoryClient.SendMessage("Testerino");
            }
            Console.ReadLine();
        }
    }
}
