using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory.Properties;

namespace Memory
{
    public partial class GameServer : Form
    {
        string TempName;
        public static Label TempConLabel = new Label();
        bool host = false;
        List<Point> PointLocation = new List<Point>();
        public static List<Point> RandomButLocation = new List<Point>();

        public GameServer()
        {
            InitializeComponent();

            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
            foreach (Button x in ButtonGrid)
            {
                x.Visible = false;
            }

            HC_Label.Visible = false;
            HostButton.Visible = false;
            ClientButton.Visible = false;
            ConLabel.Visible = false;
        }

        void SetupGame()
        {
            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
            foreach (Button x in ButtonGrid)
            {
                PointLocation.Add(x.Location);
            }

            Random ButtonLocatie = new Random();
            foreach (Button button in ButtonGrid)
            {
                int next = ButtonLocatie.Next(PointLocation.Count);
                Point p = PointLocation[next];
                button.Location = p;
                PointLocation.Remove(p);
            }

            foreach (Button x in ButtonGrid)
            {
                RandomButLocation.Add(x.Location);
            }

        }

        #region kaarten
        private void GridButton1_Click(object sender, EventArgs e)
        {
			GridButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			GridButton1.BackgroundImage = Resources.Steam;
        }

        private void GridButton1Dup_Click(object sender, EventArgs e)
        {
            GridButton1Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton1Dup.BackgroundImage = Resources.Steam;
        }

        private void GridButton2_Click(object sender, EventArgs e)
        {
            GridButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton2.BackgroundImage = Resources.TwitchLogo;
        }

        private void GridButton2Dup_Click(object sender, EventArgs e)
        {
            GridButton2Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton2Dup.BackgroundImage = Resources.TwitchLogo;
        }

        private void GridButton3_Click(object sender, EventArgs e)
        {
            GridButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton3.BackgroundImage = Resources.fb;
        }

        private void GridButton3Dup_Click(object sender, EventArgs e)
        {
            GridButton3Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton3Dup.BackgroundImage = Resources.fb;
        }

        private void GridButton4_Click(object sender, EventArgs e)
        {
            GridButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton4.BackgroundImage = Resources.Reddit;
        }

        private void GridButton4Dup_Click(object sender, EventArgs e)
        {
            GridButton4Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton4Dup.BackgroundImage = Resources.Reddit;
        }

        private void GridButton5_Click(object sender, EventArgs e)
        {
            GridButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton5.BackgroundImage = Resources._9gag;
        }

        private void GridButton5Dup_Click(object sender, EventArgs e)
        {
            GridButton5Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton5Dup.BackgroundImage = Resources._9gag;
        }

        private void GridButton6_Click(object sender, EventArgs e)
        {
            GridButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton6.BackgroundImage = Resources.Twitter;
        }

        private void GridButton6Dup_Click(object sender, EventArgs e)
        {
            GridButton6Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton6Dup.BackgroundImage = Resources.Twitter;
        }

        private void GridButton7_Click(object sender, EventArgs e)
        {
            GridButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton7.BackgroundImage = Resources.Youtube;
        }

        private void GridButton7Dup_Click(object sender, EventArgs e)
        {
            GridButton7Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton7Dup.BackgroundImage = Resources.Youtube;
        }

        private void GridButton8_Click(object sender, EventArgs e)
        {
            GridButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton8.BackgroundImage = Resources.Google;
        }

        private void GridButton8Dup_Click(object sender, EventArgs e)
        {
            GridButton8Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton8Dup.BackgroundImage = Resources.Google;
        }
#endregion

        private void HostButton_Click(object sender, EventArgs e)
        {
            ServerHost.tempGridbutton.Location = GridButton1.Location;
            SetupGame();
            ServerHost.StartServer();
            host = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (host == true)
            {
                ServerHost.SendGameState();
            }
            else
            {
                //ConLabel.Text = ServerClient.ReceiveMessage();
                ServerClient.RecieveGamaData();
                Point[] ButtonGrid = ServerClient.TempRandomButLocation.ToArray();
            }
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ServerClient.StartClient();
        }

        private void NaamButton_Click(object sender, EventArgs e)
        {
            NaamLabel.Text = "Naam: " + NaamTextBox.Text;
            TempName = NaamTextBox.Text;
            NaamTextBox.Visible = false;
            NaamButton.Visible = false;
            HC_Label.Visible = true;
            HostButton.Visible = true;
            ClientButton.Visible = true;
            ConLabel.Visible = true;

            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
            foreach (Button x in ButtonGrid)
            {
                x.Visible = true;
            }
        }
    }
}