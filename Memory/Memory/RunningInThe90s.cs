using Memory.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/// <summary>
/// De getimede Gamemode, met alle code lokaal in deze class
/// </summary>
namespace Memory
{
    public partial class RunningInThe90s : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        Button Kaart1Select, Kaart2Select;
        string player1;
        int PuntenPlayer1, TotaalMatches, lengte;
        List<Point> punten = new List<Point>();
        List<string> matchlist = new List<string>();
        string thema = Memory.SettingsPage_Save.LoadData();



        public RunningInThe90s()
        {
            InitializeComponent();

            axWindowsMediaPlayer1.Visible = false;

            CenterToScreen();

            RunningLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            label1.Font = new Font("Arial", 16, FontStyle.Bold);

            axWindowsMediaPlayer1.URL = "Run90s.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();

            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
            foreach (var x in ButtonGrid)
            {
                x.Visible = false;
                punten.Add(x.Location);
            }
            Random ButtonLocatie = new Random();
            foreach (Button Button in ButtonGrid)
            {
                int next = ButtonLocatie.Next(punten.Count);
                Point p = punten[next];
                Button.Location = p;
                punten.Remove(p);
            }

            Player1LabelInvoer.Font = new Font("Arial", 8, FontStyle.Bold);
            Player1LabelInvoer.ForeColor = System.Drawing.Color.White;
            Points1.Font = new Font("Arial", 8, FontStyle.Bold);
            Points1.ForeColor = System.Drawing.Color.White;
            ChangeCursor();

        //deze method veranderd de mouse cursor
        void ChangeCursor()
            {
                Bitmap bmp = new Bitmap(Resources.cur1031);
                Cursor c = new Cursor(bmp.GetHicon());
                this.Cursor = c;
            }
        }

		// Magische code die de flickering in de form fixt
		protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        //Deze method geeft het speelbord weer na het invullen van een naam
        private void PlayRunningInthe90s()
        {
            if (Player1Textbox.Text == "")
            {
                MessageBox.Show("Je moet een naam invullen!");
            }

            else
            {
                RunningTimer.Start();
                Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };

                foreach (var x in ButtonGrid)
                {
                    x.Visible = true;
                }
                Reset.Visible = true;
                PuntenPlayer1 = 0;
                TotaalMatches = 0;
                Points1.Text = Convert.ToString(PuntenPlayer1);
                Player1Textbox.Visible = false;
                Player1LabelInvoer.Visible = true;
                Points1.Visible = true;
                Speler1.Visible = true;
                pictureBox1.Visible = false;
                Speler1.Visible = true;
                play.Visible = false;
                RunningTimer.Enabled = false;

                Player1LabelInvoer.Text = Player1Textbox.Text;

                player1 = Player1LabelInvoer.Text;
                switch (thema)
                {
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

        //Deze methode checkt of er sprake is van een match bij het aanklikken van 2 kaarten
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
						matchlist.Add(Kaart1Select.Name);
						matchlist.Add(Kaart2Select.Name);
						lengte += 2;
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
						player.Stop();
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
                    GC.Collect();

                    foreach (var x in ButtonGrid)
                    {
                        x.Enabled = true;
                    }
                }
            }
        }

        //Deze vorm houd het aantal behaalde punten bij de de spelers en checkt een eventueel einde van het spel
        private void Point_Add()
        {
            PuntenPlayer1++;
            TotaalMatches++;
            Points1.Text = Convert.ToString(PuntenPlayer1);
            EndGame_Check();
        }

        //Deze methode reset de gam, mits dit is aangevraagd
        private void Reset_Function()
        {
            Memory.HomePage f2 = new Memory.HomePage();
            f2.runningreset();
            Dispose();
            GC.Collect();
        }
        
        //Deze methode checkt of het spel beeindigd is en geeft hierbij een geluidseffect en message indien nodig
		private void EndGame_Check()
        {
            if (TotaalMatches == 8)
            {
                RunningTimer.Enabled = false;
                string bufferstring = RunningLabel.Text;
                string buf1 = bufferstring.Split(':')[0];
                string buf2 = bufferstring.Split(':')[1];
                bufferstring = buf1 + "," + buf2;
                double score = double.Parse(bufferstring);
                Memory.RunningSave.SaveData(player1, score);
                player.SoundLocation = "tada.wav";
                player.Play();
                MessageBox.Show("Gefeliciteerd " + player1 + " je hebt gewonnen in " + RunningLabel.Text + " seconde!", "Einde Spel", MessageBoxButtons.OK);
                DialogResult Klaar = MessageBox.Show("Wil je een nieuw spel spelen?", "Nieuw spel", MessageBoxButtons.YesNo);
                player.Stop();

                if (Klaar == DialogResult.Yes)
                {
                    Reset_Function();
                }
                if (Klaar == DialogResult.No)
                {
                    Sluiten();
                }
            }    
        }

        //Button_click event voor de resetmethode
        private void Reset_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            DialogResult ResetGame = MessageBox.Show("Weet je zeker dat je opnieuw wilt beginnen? Je voortgang zal verloren gaan", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ResetGame == DialogResult.Yes)
            {
                Reset_Function();
            }
        }

        //Button_click event voor de exitbutton
        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            await Task.Delay(300);
            player.Stop();
            DialogResult ExitGame = MessageBox.Show("Weet u zeker dat u het spel wil verlaten? Onopgeslagen progressie zal verloren gaan! ", "Exit", MessageBoxButtons.YesNo);

            if (ExitGame == DialogResult.Yes)
            {
                Sluiten();
            }
        }

        //Button_click event voor de play_button, die tevens de timer laat verschijnen
        private void play_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            PlayRunningInthe90s();
            RunningTimer.Enabled = true;
            RunningLabel.Visible = true;
            label1.Visible = true;
        }

        #region kaarten
        private void GridButton1_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton1);
            Check_kaart();
        }

        private void GridButton1Dup_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton1Dup);
            Check_kaart();
        }

        private void GridButton2_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton2);
            Check_kaart();
        }

        private void GridButton2Dup_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton2Dup);
            Check_kaart();
        }

        private void GridButton3_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton3);
            Check_kaart();
        }

        private void GridButton3Dup_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton3Dup);
            Check_kaart();
        }

        private void GridButton4_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton4);
            Check_kaart();
        }

        private void GridButton4Dup_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton4Dup);
            Check_kaart();
        }

        private void GridButton5_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton5);
            Check_kaart();
        }

        private void GridButton5Dup_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton5Dup);
            Check_kaart();
        }

        private void GridButton6_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton6);
            Check_kaart();
        }

        private void GridButton6Dup_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton6Dup);
            Check_kaart();
        }

        private void GridButton7_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton7);
            Check_kaart();
        }

        private void GridButton7Dup_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton7Dup);
            Check_kaart();
        }

        private void GridButton8_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton8);
            Check_kaart();
        }

        private void GridButton8Dup_Click(object sender, EventArgs e)
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
            Click_kaart(GridButton8Dup);
            Check_kaart();
        }
        #endregion

        int seconde = 0;
        int tijds = -1;

        //Timer
        private void RunningTimer_Tick(object sender, EventArgs e)
        {
            tijds++;
            RunningLabel.Text = seconde + ":" + tijds.ToString();

            if (tijds == 9)
            {
                seconde++;
                tijds = 0;
            }
        }

        //Dit event zorgt ervoor dat het hoofdmenu verschijnt, wanneer deze form sluit
        private void RunningInThe90s_FormClosing(object sender, FormClosingEventArgs e)
        {
            Memory.HomePage f2 = new Memory.HomePage();
            f2.Tonen();
            Dispose();
            GC.Collect();
        }

        //zorgt ervoor dat de achtergrondmuziek afspeelt wanneer de timer op de timerinterval tickt
        private void timer1_Tick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timer1.Stop();
        }

        private void Reset_Click_1(object sender, EventArgs e)
        {
            {
                player.SoundLocation = "click.wav";
                player.Play();
                DialogResult ResetGame = MessageBox.Show("Weet je zeker dat je opnieuw wilt beginnen? Je voortgang zal verloren gaan", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResetGame == DialogResult.Yes)
                {
                    Reset_Function();
                }
            }
        }

        //Deze timer zorgt ervoor dat de achtergrondmuziek herhaalt wordt nadat het is afgelopen
        private void timer2_Tick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        public void Saveclass_Click(object sender, EventArgs e)
        {
            string[] matcharray = new string[20];
            matchlist.CopyTo(matcharray);
            //click van deze button saved alle huidige data in .sav
        }

        //methode voor het sluiten van de form
        public void Sluiten()
        {
            Close();
            Dispose();
            GC.Collect();
        }
    }

}


