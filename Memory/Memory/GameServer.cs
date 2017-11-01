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
        string TempName, PlayerBeurt, player1, player2;
        int PuntenPlayer1, PuntenPlayer2, TotaalMatches;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public static Label TempConLabel = new Label();
        Button Kaart1Select, Kaart2Select;
        bool host = false;
        List<Point> PointLocation = new List<Point>();
        public static List<Point> RandomButLocation = new List<Point>();
        string thema = Memory.SettingsPage_Save.LoadData();

        public GameServer()
        {
            InitializeComponent();

            ChangeCursor();

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

        protected override CreateParams CreateParams //THE MAGIC CODE "It Just Works™"
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
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

        private void Click_kaart(Button Buttonclick)
        {
            if (Kaart1Select == null)
            {
                Kaart1Select = Buttonclick;
            }
            else if (Kaart1Select != null && Kaart2Select == null)
            {
                Kaart2Select = Buttonclick;
            }
        }

        public async void Check_kaart()
        {
            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
            if (Kaart1Select != null && Kaart2Select != null)
            {
                if (Kaart1Select.Tag == Kaart2Select.Tag)
                {
                    if (Kaart1Select.Name == Kaart2Select.Name)
                    {
                        Kaart2Select = null;
                    }
                    else
                    {
                        player.SoundLocation = "ping.wav";
                        player.Play();
                        foreach (var x in ButtonGrid)
                        {
                            x.Enabled = false;
                        }

                        await Task.Delay(1000);
                        Kaart1Select.Visible = false;
                        Kaart2Select.Visible = false;
                        Kaart1Select = null;
                        Kaart2Select = null;
                        Point_Add();
                        GC.Collect();

                        foreach (var x in ButtonGrid)
                        {
                            x.Enabled = true;
                        }
                    }
                }
                else
                {
                    foreach (var x in ButtonGrid)
                    {
                        x.Enabled = false;
                    }

                    await Task.Delay(1000);
                    switch (thema)
                    {
                        case "Media":
                            Kaart1Select.BackgroundImage = Resources.cardback;
                            Kaart2Select.BackgroundImage = Resources.cardback;
                            break;
                        case "Films":
                            Kaart1Select.BackgroundImage = Resources.clapperboard;
                            Kaart2Select.BackgroundImage = Resources.clapperboard;
                            break;
                        case "Games":
                            Kaart1Select.BackgroundImage = Resources.controller_cardback;
                            Kaart2Select.BackgroundImage = Resources.controller_cardback;
                            break;
                    }
                    Kaart1Select = null;
                    Kaart2Select = null;
                    Change_Beurt();
                    GC.Collect();

                    foreach (var x in ButtonGrid)
                    {
                        x.Enabled = true;
                    }
                    foreach (var x in ButtonGrid)
                    {
                        x.Text = "";
                    }
                }
            }
        }

        private void Point_Add()
        {
            if (PlayerBeurt == player1)
            {
                PuntenPlayer1++;
                TotaalMatches++;
                Points1.Text = Convert.ToString(PuntenPlayer1);
                EndGame_Check();
            }
            else
            {
                PuntenPlayer2++;
                TotaalMatches++;
                Points2.Text = Convert.ToString(PuntenPlayer2);
                EndGame_Check();
            }
        }

        private void Change_Beurt()
        {
            if (PlayerBeurt == player1)
            {
                PlayerBeurt = player2;
            }
            else
            {
                PlayerBeurt = player1;
            }
            BeurtLabel.Text = PlayerBeurt;
        }

        private async void EndGame_Check()
        {
            if (TotaalMatches == 8)
            {
                if (PuntenPlayer1 > PuntenPlayer2)
                {
                    player.SoundLocation = "tada.wav";
                    player.Play();
                    MessageBox.Show("Gefeliciteerd " + player1 + " je hebt gewonnen!", "Einde Spel", MessageBoxButtons.OK);
                    //Memory.Highscores_save.SaveData(player1, PuntenPlayer1);
                    await Task.Delay(2000);
                    player.Stop();
                }
                else if (PuntenPlayer1 == PuntenPlayer2)
                {
                    player.SoundLocation = "wow.wav";
                    player.Play();
                    MessageBox.Show("WOW, " + player1 + " heeft gelijk gespeeld met " + player2 + "!", "Einde Spel", MessageBoxButtons.OK);
                    await Task.Delay(2000);
                    player.Stop();
                }
                else
                {
                    player.SoundLocation = "tada.wav";
                    player.Play();
                    MessageBox.Show("Gefeliciteerd " + player2 + " je hebt gewonnen!", "Einde Spel", MessageBoxButtons.OK);
                    //Memory.Highscores_save.SaveData(player2, PuntenPlayer2);
                    await Task.Delay(2000);
                    player.Stop();
                }
            }
        }

        private void Play_Game()
        {
            
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
                Point[] ButtonGridLocation = ServerClient.TempRandomButLocation.ToArray();
                for (int i = 0; i < ButtonGridLocation.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            GridButton1.Location = ButtonGridLocation[i];
                            break;
                        case 1:
                            GridButton1Dup.Location = ButtonGridLocation[i];
                            break;
                        case 2:
                            GridButton2.Location = ButtonGridLocation[i];
                            break;
                        case 3:
                            GridButton2Dup.Location = ButtonGridLocation[i];
                            break;
                        case 4:
                            GridButton3.Location = ButtonGridLocation[i];
                            break;
                        case 5:
                            GridButton3Dup.Location = ButtonGridLocation[i];
                            break;
                        case 6:
                            GridButton4.Location = ButtonGridLocation[i];
                            break;
                        case 7:
                            GridButton4Dup.Location = ButtonGridLocation[i];
                            break;
                        case 8:
                            GridButton5.Location = ButtonGridLocation[i];
                            break;
                        case 9:
                            GridButton5Dup.Location = ButtonGridLocation[i];
                            break;
                        case 10:
                            GridButton6.Location = ButtonGridLocation[i];
                            break;
                        case 11:
                            GridButton6Dup.Location = ButtonGridLocation[i];
                            break;
                        case 12:
                            GridButton7.Location = ButtonGridLocation[i];
                            break;
                        case 13:
                            GridButton7Dup.Location = ButtonGridLocation[i];
                            break;
                        case 14:
                            GridButton8.Location = ButtonGridLocation[i];
                            break;
                        case 15:
                            GridButton8Dup.Location = ButtonGridLocation[i];
                            break;
                    }
                }
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
        void ChangeCursor()
        {
            Bitmap bmp = new Bitmap(Resources.cur1031);
            Cursor c = new Cursor(bmp.GetHicon());
            this.Cursor = c;
        }
    }
}