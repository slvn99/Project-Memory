using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class GameServer : Form
    {
        public GameServer()
        {
            InitializeComponent();
        }
        public static Label label2 = new Label();
        bool loop = true;

        
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("SERVER of CLIENT");
        //    string keuze = Console.ReadLine();
        //    if (keuze == "SERVER")
        //    {
        //        ServerHost.StartServer();
        //        Console.WriteLine(ServerHost.ReceiveMessage());
        //    }

        //    else
        //    {
        //        ServerClient.StartClient();
        //        ServerClient.SendMessage("Testerino");
        //    }
        //    Console.ReadLine();
        //}

        private void HostButton_Click(object sender, EventArgs e)
        {
            ServerHost.StartServer();
            label1.Text = (ServerHost.ReceiveMessage());
            //do
            //{
            //    label1.Text = label2.Text;
            //} while (loop == true);
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ServerClient.StartClient();
            ServerClient.SendMessage("Testerino");
        }
    }
}