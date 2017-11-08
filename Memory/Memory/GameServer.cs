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

            hostofclient.Visible = false;
            host_button.Visible = false;
            client_button.Visible = false;
            ip.Visible = false;
            IpTextBox.Visible = false;
            connect_button.Visible = false;
            PuntenLocal.Visible = false;
            PuntenOther.Visible = false;

            switch (thema)
            {
                default:
                    this.BackgroundImage = Resources.media_achtergrond;
                    break;
                case "Media":
                    this.BackgroundImage = Resources.media_achtergrond;
                    break;
                case "Films":
                    this.BackgroundImage = Resources.popcorn_background;
                    GridButton1.BackgroundImage = Resources.clapperboard;
                    GridButton1Dup.BackgroundImage = Resources.clapperboard;
                    GridButton2.BackgroundImage = Resources.clapperboard;
                    GridButton2Dup.BackgroundImage = Resources.clapperboard;
                    GridButton3.BackgroundImage = Resources.clapperboard;
                    GridButton3Dup.BackgroundImage = Resources.clapperboard;
                    GridButton4.BackgroundImage = Resources.clapperboard;
                    GridButton4Dup.BackgroundImage = Resources.clapperboard;
                    GridButton5.BackgroundImage = Resources.clapperboard;
                    GridButton5Dup.BackgroundImage = Resources.clapperboard;
                    GridButton6.BackgroundImage = Resources.clapperboard;
                    GridButton6Dup.BackgroundImage = Resources.clapperboard;
                    GridButton7.BackgroundImage = Resources.clapperboard;
                    GridButton7Dup.BackgroundImage = Resources.clapperboard;
                    GridButton8.BackgroundImage = Resources.clapperboard;
                    GridButton8Dup.BackgroundImage = Resources.clapperboard;
                    break;
                case "Games":
                    this.BackgroundImage = Resources.controller;
                    GridButton1.BackgroundImage = Resources.controller_cardback;
                    GridButton1Dup.BackgroundImage = Resources.controller_cardback;
                    GridButton2.BackgroundImage = Resources.controller_cardback;
                    GridButton2Dup.BackgroundImage = Resources.controller_cardback;
                    GridButton3.BackgroundImage = Resources.controller_cardback;
                    GridButton3Dup.BackgroundImage = Resources.controller_cardback;
                    GridButton4.BackgroundImage = Resources.controller_cardback;
                    GridButton4Dup.BackgroundImage = Resources.controller_cardback;
                    GridButton5.BackgroundImage = Resources.controller_cardback;
                    GridButton5Dup.BackgroundImage = Resources.controller_cardback;
                    GridButton6.BackgroundImage = Resources.controller_cardback;
                    GridButton6Dup.BackgroundImage = Resources.controller_cardback;
                    GridButton7.BackgroundImage = Resources.controller_cardback;
                    GridButton7Dup.BackgroundImage = Resources.controller_cardback;
                    GridButton8.BackgroundImage = Resources.controller_cardback;
                    GridButton8Dup.BackgroundImage = Resources.controller_cardback;
                    break;
            }
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

        public void CloseApplication()
        { 
            this.Close();
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

                PuntenLocal.Text = "0";
                PuntenOther.Text = "0";
                PuntenLocal.Visible = true;
                PuntenOther.Visible = true;
                hostofclient.Visible = false;
                host_button.Visible = false;
                client_button.Visible = false;

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

                PuntenLocal.Text = "0";
                PuntenOther.Text = "0";
                PuntenLocal.Visible = true;
                PuntenOther.Visible = true;
                ip.Visible = false;
                IpTextBox.Visible = false;
                connect_button.Visible = false;

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
                PuntenOther.Text = Convert.ToString(PuntenOtherPlayer);
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
                switch (thema)
                {
                    default:
                        GridButton1.BackgroundImage = Resources.Steam;
                        break;
                    case "Media":
                        GridButton1.BackgroundImage = Resources.Steam;
                        break;
                    case "Films":
                        GridButton1.BackgroundImage = Resources.ff130;
                        break;
                    case "Games":
                        GridButton1.BackgroundImage = Resources.ac130;
                        break;
                }
            }
            if (x == GridButton1Dup)
            {
                switch (thema)
                {
                    default:
                        GridButton1Dup.BackgroundImage = Resources.Steam;
                        break;
                    case "Media":
                        GridButton1Dup.BackgroundImage = Resources.Steam;
                        break;
                    case "Films":
                        GridButton1Dup.BackgroundImage = Resources.ff130;
                        break;
                    case "Games":
                        GridButton1Dup.BackgroundImage = Resources.ac130;
                        break;
                }
            }
            if (x == GridButton2)
            {
                switch (thema)
                {
                    default:
                        GridButton2.BackgroundImage = Resources.fb;
                        break;
                    case "Media":
                        GridButton2.BackgroundImage = Resources.fb;
                        break;
                    case "Films":
                        GridButton2.BackgroundImage = Resources.hp130;
                        break;
                    case "Games":
                        GridButton2.BackgroundImage = Resources.zelda130;
                        break;
                }
            }
            if (x == GridButton2Dup)
            {
                switch (thema)
                {
                    default:
                        GridButton2Dup.BackgroundImage = Resources.fb;
                        break;
                    case "Media":
                        GridButton2Dup.BackgroundImage = Resources.fb;
                        break;
                    case "Films":
                        GridButton2Dup.BackgroundImage = Resources.hp130;
                        break;
                    case "Games":
                        GridButton2Dup.BackgroundImage = Resources.zelda130;
                        break;
                }
            }
            if (x == GridButton3)
            {
                switch (thema)
                {
                    default:
                        GridButton3.BackgroundImage = Resources.Google;
                        break;
                    case "Media":
                        GridButton3.BackgroundImage = Resources.Google;
                        break;
                    case "Films":
                        GridButton3.BackgroundImage = Resources.shrek130;
                        break;
                    case "Games":
                        GridButton3.BackgroundImage = Resources.witcher130;
                        break;
                }
            }
            if (x == GridButton3Dup)
            {
                switch (thema)
                {
                    default:
                        GridButton3Dup.BackgroundImage = Resources.Google;
                        break;
                    case "Media":
                        GridButton3Dup.BackgroundImage = Resources.Google;
                        break;
                    case "Films":
                        GridButton3Dup.BackgroundImage = Resources.shrek130;
                        break;
                    case "Games":
                        GridButton3Dup.BackgroundImage = Resources.witcher130;
                        break;
                }
            }
            if (x == GridButton4)
            {
                switch (thema)
                {
                    default:
                        GridButton4.BackgroundImage = Resources.Youtube;
                        break;
                    case "Media":
                        GridButton4.BackgroundImage = Resources.Youtube;
                        break;
                    case "Films":
                        GridButton4.BackgroundImage = Resources.indiana130;
                        break;
                    case "Games":
                        GridButton4.BackgroundImage = Resources.fifa130;
                        break;
                }
            }
            if (x == GridButton4Dup)
            {
                switch (thema)
                {
                    default:
                        GridButton4Dup.BackgroundImage = Resources.Youtube;
                        break;
                    case "Media":
                        GridButton4Dup.BackgroundImage = Resources.Youtube;
                        break;
                    case "Films":
                        GridButton4Dup.BackgroundImage = Resources.indiana130;
                        break;
                    case "Games":
                        GridButton4Dup.BackgroundImage = Resources.fifa130;
                        break;
                }
            }
            if (x == GridButton5)
            {
                switch (thema)
                {
                    default:
                        GridButton5.BackgroundImage = Resources.Twitter;
                        break;
                    case "Media":
                        GridButton5.BackgroundImage = Resources.Twitter;
                        break;
                    case "Films":
                        GridButton5.BackgroundImage = Resources.lotr_130;
                        break;
                    case "Games":
                        GridButton5.BackgroundImage = Resources.need_for_speed130;
                        break;
                }
            }
            if (x == GridButton5Dup)
            {
                switch (thema)
                {
                    default:
                        GridButton5Dup.BackgroundImage = Resources.Twitter;
                        break;
                    case "Media":
                        GridButton5Dup.BackgroundImage = Resources.Twitter;
                        break;
                    case "Films":
                        GridButton5Dup.BackgroundImage = Resources.lotr_130;
                        break;
                    case "Games":
                        GridButton5Dup.BackgroundImage = Resources.need_for_speed130;
                        break;
                }
            }
            if (x == GridButton6)
            {
                switch (thema)
                {
                    default:
                        GridButton6.BackgroundImage = Resources._9gag;
                        break;
                    case "Media":
                        GridButton6.BackgroundImage = Resources._9gag;
                        break;
                    case "Films":
                        GridButton6.BackgroundImage = Resources.avengers130;
                        break;
                    case "Games":
                        GridButton6.BackgroundImage = Resources.gta130;
                        break;
                }
            }
            if (x == GridButton6Dup)
            {
                switch (thema)
                {
                    default:
                        GridButton6Dup.BackgroundImage = Resources._9gag;
                        break;
                    case "Media":
                        GridButton6Dup.BackgroundImage = Resources._9gag;
                        break;
                    case "Films":
                        GridButton6Dup.BackgroundImage = Resources.avengers130;
                        break;
                    case "Games":
                        GridButton6Dup.BackgroundImage = Resources.gta130;
                        break;
                }
            }
            if (x == GridButton7)
            {
                switch (thema)
                {
                    default:
                        GridButton7.BackgroundImage = Resources.TwitchLogo;
                        break;
                    case "Media":
                        GridButton7.BackgroundImage = Resources.TwitchLogo;
                        break;
                    case "Films":
                        GridButton7.BackgroundImage = Resources.star_trek130;
                        break;
                    case "Games":
                        GridButton7.BackgroundImage = Resources.portal130;
                        break;
                }
            }
            if (x == GridButton7Dup)
            {
                switch (thema)
                {
                    default:
                        GridButton7Dup.BackgroundImage = Resources.TwitchLogo;
                        break;
                    case "Media":
                        GridButton7Dup.BackgroundImage = Resources.TwitchLogo;
                        break;
                    case "Films":
                        GridButton7Dup.BackgroundImage = Resources.star_trek130;
                        break;
                    case "Games":
                        GridButton7Dup.BackgroundImage = Resources.portal130;
                        break;
                }
            }
            if (x == GridButton8)
            {
                switch (thema)
                {
                    default:
                        GridButton8.BackgroundImage = Resources.Reddit;
                        break;
                    case "Media":
                        GridButton8.BackgroundImage = Resources.Reddit;
                        break;
                    case "Films":
                        GridButton8.BackgroundImage = Resources.starwars130;
                        break;
                    case "Games":
                        GridButton8.BackgroundImage = Resources.halo130;
                        break;
                }
            }
            if (x == GridButton8Dup)
            {
                switch (thema)
                {
                    default:
                        GridButton8Dup.BackgroundImage = Resources.Reddit;
                        break;
                    case "Media":
                        GridButton8Dup.BackgroundImage = Resources.Reddit;
                        break;
                    case "Films":
                        GridButton8Dup.BackgroundImage = Resources.starwars130;
                        break;
                    case "Games":
                        GridButton8Dup.BackgroundImage = Resources.halo130;
                        break;
                }
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

        private void client_button_Click(object sender, EventArgs e)
        {
            ip.Visible = true;
            IpTextBox.Visible = true;
            connect_button.Visible = true;
            hostofclient.Visible = false;
            host_button.Visible = false;
            client_button.Visible = false;
        }

        private void host_button_Click(object sender, EventArgs e)
        {
            host = true;
            host_button.Enabled = false;
            client_button.Enabled = false;
            RandomizeButtons();
            ServerHost.StartServer();
            CheckConnect();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            ServerClient.HostIP = IpTextBox.Text;
            ServerClient.StartClient();
            if (ServerClient.ClientConnection == true)
            {
                SetupGame();
            }
        }

        private void bevestig_button_Click(object sender, EventArgs e)
        {
            if (NaamTextBox.Text != "")
            {
                LocalPlayer = NaamTextBox.Text;
                LocalPlayerLabel.Text = LocalPlayer;

                type_uw_naam.Visible = false;
                NaamTextBox.Visible = false;
                bevestig_button.Visible = false;
                hostofclient.Visible = true;
                host_button.Visible = true;
                client_button.Visible = true;
            }
            else
            {
                MessageBox.Show("ERROR, je moet een naam invullen.", "Naam Invullen!", MessageBoxButtons.OK);
            }
        }

        private void IpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ip.Visible = true;
            IpTextBox.Visible = true;
            connect_button.Visible = true;
            hostofclient.Visible = false;
            host_button.Visible = false;
            client_button.Visible = false;
        }

        private void HostButton_Click(object sender, EventArgs e)
        {
            host = true;
            host_button.Enabled = false;
            client_button.Enabled = false;
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
                host_button.Enabled = true;
                client_button.Enabled = true;
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

                type_uw_naam.Visible = false;
                NaamTextBox.Visible = false;
                bevestig_button.Visible = false;
                hostofclient.Visible = true;
                host_button.Visible = true;
                client_button.Visible = true;
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