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

/// <summary>
/// de form om de multiplayer te spelen, deze roept de correcte methodes aan voor host of client class
/// en displayed alles, dit is het hart van de multiplayer
/// </summary>
namespace Memory
{
    public partial class GameServer : Form
    {
        public static string PlayerBeurt, LocalPlayer, OtherPlayer, player1, player2;
        public static string[] TurnArray = new string[2];
        int PuntenLocalPlayer, PuntenOtherPlayer, TotaalMatches;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public static Label TempConLabel = new Label();
        Button Kaart1Select, Kaart2Select;
        bool host = false;
        List<Point> PointLocation = new List<Point>();
        public static List<Point> RandomButLocation = new List<Point>();
        string thema = Memory.SettingsPage_Save.LoadData();
        public static bool Connectie = false;

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
            GeefIpLabel.Visible = false;
            IpTextBox.Visible = false;
            ConnectButton.Visible = false;
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

        internal static void CloseApplication()
        {
            GameServer.CloseApplication();
        }

        void RandomizeButtons()
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

        void SetupGame()
        {
            if (host == true)
            {
                player1 = LocalPlayer;
                ServerHost.SendGameState();
                ServerHost.RecieveName();
                OtherPlayer = ServerHost.ClientName;
                OtherPlayerLabel.Text = OtherPlayer;
                player2 = OtherPlayer;
                PlayerBeurt = player1;
                BeurtLabel.Text = PlayerBeurt;
                ServerHost.SendName();

                HC_Label.Visible = false;
                HostButton.Visible = false;
                ClientButton.Visible = false;

                Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
                foreach (Button x in ButtonGrid)
                {
                    x.Visible = true;
                }
            }
            else
            {
                player2 = LocalPlayer;
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

                ServerClient.SendName();
                ServerClient.RecieveName();
                OtherPlayer = ServerClient.HostName;
                OtherPlayerLabel.Text = OtherPlayer;
                player1 = OtherPlayer;
                PlayerBeurt = player1;
                BeurtLabel.Text = PlayerBeurt;

                GeefIpLabel.Visible = false;
                IpTextBox.Visible = false;
                ConnectButton.Visible = false;

                Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
                foreach (Button x in ButtonGrid)
                {
                    x.Visible = true;
                    x.Enabled = false;
                }

                backgroundWorker.RunWorkerAsync();
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
                    else if(Kaart1Select.Name != Kaart2Select.Name)
                    {
                        player.SoundLocation = "ping.wav";
                        player.Play();
                        foreach (var x in ButtonGrid)
                        {
                            x.Enabled = false;
                        }

                        await Task.Delay(3000);
                        Kaart1Select.Visible = false;
                        Kaart2Select.Visible = false;
                        TurnArray[0] = Kaart1Select.Name;
                        TurnArray[1] = Kaart2Select.Name;

                        if (host == true)
                        {
                            ServerHost.SendTurn();
                        }
                        else
                        {
                            ServerClient.SendTurn();
                        }

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

                    await Task.Delay(3000);
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

                    TurnArray[0] = Kaart1Select.Name;
                    TurnArray[1] = Kaart2Select.Name;

                    if (host == true)
                    {
                        ServerHost.SendTurn();
                    }
                    else
                    {
                        ServerClient.SendTurn();
                    }

                    Kaart1Select = null;
                    Kaart2Select = null;
                    Change_Beurt();
                    GC.Collect();

                    foreach(var x in ButtonGrid)
                    {
                        x.Enabled = false;
                    }
                    backgroundWorker.RunWorkerAsync();
                }
            }
        }

        private void Point_Add()
        {
            if (PlayerBeurt == LocalPlayer)
            {
                PuntenLocalPlayer++;
                TotaalMatches++;
                PuntenLocal.Text = Convert.ToString(PuntenLocalPlayer);
                EndGame_Check();
            }
            else
            {
                PuntenOtherPlayer++;
                TotaalMatches++;
                PuntenOther.Text = Convert.ToString(OtherPlayer);
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
                if (PuntenLocalPlayer > PuntenOtherPlayer)
                {
                    player.SoundLocation = "tada.wav";
                    player.Play();
                    MessageBox.Show("Gefeliciteerd " + LocalPlayer + " je hebt gewonnen!", "Einde Spel", MessageBoxButtons.OK);
                    await Task.Delay(2000);
                    player.Stop();
                }
                else if (PuntenLocalPlayer == PuntenOtherPlayer)
                {
                    player.SoundLocation = "wow.wav";
                    player.Play();
                    MessageBox.Show("WOW, " + LocalPlayer + " heeft gelijk gespeeld met " + OtherPlayer + "!", "Einde Spel", MessageBoxButtons.OK);
                    await Task.Delay(2000);
                    player.Stop();
                }
                else
                {
                    player.SoundLocation = "tada.wav";
                    player.Play();
                    MessageBox.Show("Gefeliciteerd " + OtherPlayer + " je hebt gewonnen!", "Einde Spel", MessageBoxButtons.OK);
                    await Task.Delay(2000);
                    player.Stop();
                }
            }
        }

        #region TurnKaart
        private void TurnKaart(Button x)
        {
            if (x == GridButton1)
            {
                GridButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton1.BackgroundImage = Resources.Steam;
            }
            if (x == GridButton1Dup)
            {
                GridButton1Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton1Dup.BackgroundImage = Resources.Steam;
            }
            if (x == GridButton2)
            {
                GridButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton2.BackgroundImage = Resources.TwitchLogo;
            }
            if (x == GridButton2Dup)
            {
                GridButton2Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton2Dup.BackgroundImage = Resources.TwitchLogo;
            }
            if (x == GridButton3)
            {
                GridButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton3.BackgroundImage = Resources.fb;
            }
            if (x == GridButton3Dup)
            {
                GridButton3Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton3Dup.BackgroundImage = Resources.fb;
            }
            if (x == GridButton4)
            {
                GridButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton4.BackgroundImage = Resources.Reddit;
            }
            if (x == GridButton4Dup)
            {
                GridButton4Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton4Dup.BackgroundImage = Resources.Reddit;
            }
            if (x == GridButton5)
            {
                GridButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton5.BackgroundImage = Resources._9gag;
            }
            if (x == GridButton5Dup)
            {
                GridButton5Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton5Dup.BackgroundImage = Resources._9gag;
            }
            if (x == GridButton6)
            {
                GridButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton6.BackgroundImage = Resources.Twitter;
            }
            if (x == GridButton6Dup)
            {
                GridButton6Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton6Dup.BackgroundImage = Resources.Twitter;
            }
            if (x == GridButton7)
            {
                GridButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton7.BackgroundImage = Resources.Youtube;
            }
            if (x == GridButton7Dup)
            {
                GridButton7Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton7Dup.BackgroundImage = Resources.Youtube;
            }
            if (x == GridButton8)
            {
                GridButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton8.BackgroundImage = Resources.Google;
            }
            if (x == GridButton8Dup)
            {
                GridButton8Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                GridButton8Dup.BackgroundImage = Resources.Google;
            }
        }
        #endregion

        #region kaarten
        private void GridButton1_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton1);
            Click_kaart(GridButton1);
            Check_kaart();
        }

        private void GridButton1Dup_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton1Dup);
            Click_kaart(GridButton1Dup);
            Check_kaart();
        }

        private void GridButton2_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton2);
            Click_kaart(GridButton2);
            Check_kaart();
        }

        private void GridButton2Dup_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton2Dup);
            Click_kaart(GridButton2Dup);
            Check_kaart();
        }

        private void GridButton3_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton3);
            Click_kaart(GridButton3);
            Check_kaart();
        }

        private void GridButton3Dup_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton3Dup);
            Click_kaart(GridButton3Dup);
            Check_kaart();
        }

        private void GridButton4_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton4);
            Click_kaart(GridButton4);
            Check_kaart();
        }

        private void GridButton4Dup_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton4Dup);
            Click_kaart(GridButton4Dup);
            Check_kaart();
        }

        private void GridButton5_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton5);
            Click_kaart(GridButton5);
            Check_kaart();
        }

        private void GridButton5Dup_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton5Dup);
            Click_kaart(GridButton5Dup);
            Check_kaart();
        }

        private void GridButton6_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton6);
            Click_kaart(GridButton6);
            Check_kaart();
        }

        private void GridButton6Dup_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton6Dup);
            Click_kaart(GridButton6Dup);
            Check_kaart();
        }

        private void GridButton7_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton7);
            Click_kaart(GridButton7);
            Check_kaart();
        }

        private void GridButton7Dup_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton7Dup);
            Click_kaart(GridButton7Dup);
            Check_kaart();
        }

        private void GridButton8_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton8);
            Click_kaart(GridButton8);
            Check_kaart();
        }

        private void GridButton8Dup_Click(object sender, EventArgs e)
        {
            TurnKaart(GridButton8Dup);
            Click_kaart(GridButton8Dup);
            Check_kaart();
        }
        #endregion

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) //backgroundworker medemogenlijk gemaakt door Jonathan :D danku voor de tip!
        {
            if (host == true)
            {
                ServerHost.RecieveTurn();
            }
            else
            {
                ServerClient.RecieveTurn();
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (backgroundWorker.CancellationPending == true)
            {
                MessageBox.Show("ERROR, connectie verloren.", "Connection Lost!", MessageBoxButtons.OK);
            }
            else
            {
                if (host == true)
                {
                    TurnArray = ServerHost.TurnArray;
                }
                else
                {
                    TurnArray = ServerClient.TurnArray;
                }
                TurnPlayBack();
            }
        }

        private async void TurnPlayBack()
        {
            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
            foreach(Button x in ButtonGrid)
            {
                if (x.Name == TurnArray[0])
                {
                    Kaart1Select = x;
                }
                if (x.Name == TurnArray[1])
                {
                    Kaart2Select = x;
                }
            }

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
                        TurnKaart(Kaart1Select);
                        TurnKaart(Kaart2Select);
                        player.SoundLocation = "ping.wav";
                        player.Play();
                        foreach (var x in ButtonGrid)
                        {
                            x.Enabled = false;
                        }

                        await Task.Delay(3000);
                        Kaart1Select.Visible = false;
                        Kaart2Select.Visible = false;
                        Kaart1Select = null;
                        Kaart2Select = null;
                        Point_Add();
                        backgroundWorker.RunWorkerAsync();
                        GC.Collect();
                    }
                }
                else
                {
                    TurnKaart(Kaart1Select);
                    TurnKaart(Kaart2Select);
                    await Task.Delay(3000);
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
                }
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            await Task.Delay(300);
            player.Stop();
            DialogResult ExitGame = MessageBox.Show("Weet je zeker dat je terug naar het hoofdmenu wilt gaan? ", "Home", MessageBoxButtons.YesNo);

            if (ExitGame == DialogResult.Yes)
            {
                Sluiten();
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ServerClient.HostIP = IpTextBox.Text;
            ServerClient.StartClient();
            if (ServerClient.ClientConnection == true)
            {
                SetupGame();
            }
        }

        private void GameServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Memory.HomePage f2 = new Memory.HomePage();
            f2.Tonen();
            Dispose();
            GC.Collect();
        }

        private void IpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            GeefIpLabel.Visible = true;
            IpTextBox.Visible = true;
            ConnectButton.Visible = true;
            HC_Label.Visible = false;
            HostButton.Visible = false;
            ClientButton.Visible = false;
        }

        private void HostButton_Click(object sender, EventArgs e)
        {
            host = true;
            HostButton.Enabled = false;
            ClientButton.Enabled = false;
            RandomizeButtons();
            ServerHost.StartServer();
            CheckConnect();
        }

        private async void CheckConnect()
        {
            await Task.Delay(10000);

            if (Connectie == false)
            {
                MessageBox.Show("ERROR, Connectie timed out", "Time Out", MessageBoxButtons.OK);
                ServerHost.Listener.Stop();
                HostButton.Enabled = true;
                ClientButton.Enabled = true;
            }
            else
            {
                SetupGame();
            }
        }

        private void NaamButton_Click(object sender, EventArgs e)
        {
            if (NaamTextBox.Text != "")
            {
                LocalPlayer = NaamTextBox.Text;
                LocalPlayerLabel.Text = LocalPlayer;

                NaamLabel.Visible = false;
                NaamTextBox.Visible = false;
                NaamButton.Visible = false;
                HC_Label.Visible = true;
                HostButton.Visible = true;
                ClientButton.Visible = true;
            }
            else
            {
                MessageBox.Show("ERROR, je moet een naam invullen.", "Naam Invullen!", MessageBoxButtons.OK);
            }
        }

        void ChangeCursor()
        {
            Bitmap bmp = new Bitmap(Resources.cur1031);
            Cursor c = new Cursor(bmp.GetHicon());
            this.Cursor = c;
        }

        public void Sluiten()
        {
            Close();
            Dispose();
            GC.Collect();
        }
    }
}