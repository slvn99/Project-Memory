using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Memory.Properties;


namespace WindowsFormsApp1
{
    /// <summary>
    ///  standard gamemode, wordt geladen onder de button 'local hotseat'
    ///  2 spelers spelen tegen elkaar op het lokale apparaat, waarna de winnaar zijn score wordt opgeslagen als highscore
    ///  alle code om te checken etc. is lokaal in deze class
    /// </summary>
    public partial class Form1 : Form // Standard game 
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        Button Kaart1Select, Kaart2Select;
        string player1, player2, PlayerBeurt;
        int PuntenPlayer1, PuntenPlayer2, TotaalMatches,lengte;
        List<Point> punten = new List<Point>();
        List<string> matchlist = new List<string>();
        string thema = Memory.SettingsPage_Save.LoadData();
	

        public Form1()
        {
            InitializeComponent();

            this.ActiveControl = Player1Textbox;

            opslaan.Visible = false;

            ChangeCursor();

			//
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
            Player2LabelInvoer.Font = new Font("Arial", 8, FontStyle.Bold);
            Player2LabelInvoer.ForeColor = System.Drawing.Color.White;
            BeurtLabel.Font = new Font("Arial", 8, FontStyle.Bold);
            BeurtLabel.ForeColor = System.Drawing.Color.White;
            Points1.Font = new Font("Arial", 8, FontStyle.Bold);
            Points1.ForeColor = System.Drawing.Color.White;
            Points2.Font = new Font("Arial", 8, FontStyle.Bold);
            Points2.ForeColor = System.Drawing.Color.White;
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

		// Veranderd cursor
        void ChangeCursor()
        {
            Bitmap bmp = new Bitmap (Resources.cur1031);
            Cursor c = new Cursor(bmp.GetHicon());
            this.Cursor = c;
        }

		// Zorgt ervoor dat je niet 2 dezelfde namen in kan vullen of helemaal niks in kan vullen
		private void Play_Game()
        {
            if (Player1Textbox.Text == "" || Player2Textbox.Text == "" || Player1Textbox.Text == " " || Player2Textbox.Text == " ")
            {
                MessageBox.Show("Je moet een naam invullen!");
            }
			else if (Player1Textbox.Text == Player2Textbox.Text)
			{
				MessageBox.Show("Voer 2 verschillende namen in");
			}

			// Als dat niet het geval was start hij het spel
            else
            {
                timer1.Start();

                Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
               
				// Maakt alle buttons visible
                foreach (var x in ButtonGrid)
                {
                    x.Visible = true;
                }
                
				// Maakt alle onnodige buttons invisible en nodige buttons visible
                PuntenPlayer1 = 0;
                PuntenPlayer2 = 0;
                TotaalMatches = 0;
                Points1.Text = Convert.ToString(PuntenPlayer1);
                Points2.Text = Convert.ToString(PuntenPlayer2);
                Player1Textbox.Visible = false;
                Player2Textbox.Visible = false;
                Player1LabelInvoer.Visible = true;
                Player2LabelInvoer.Visible = true;
                Points1.Visible = true;
                Points2.Visible = true;
                BeurtLabel.Visible = true;
                Beurt.Visible = true;
                opslaan.Visible = true;
                Speler1.Visible = true;
                Speler2.Visible = true;
                NaamSpeler1.Visible = false;
                NaamSpeler2.Visible = false;
				Speler1.Visible = true;
				Speler2.Visible = true;
				Beurt.Visible = true;
				play.Visible = false;
                Reset.Visible = true;
                laden.Visible = false;
                opslaan.Visible = true;
                Player1LabelInvoer.Text = Player1Textbox.Text;
                Player2LabelInvoer.Text = Player2Textbox.Text;
                player1 = Player1LabelInvoer.Text;
                player2 = Player2LabelInvoer.Text;
                PlayerBeurt = player1;
                BeurtLabel.Text = PlayerBeurt;

				// Veranderd de achtergrond en de back van de cards op basis van welke thema is geselecteerd
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
        }
        
		// Als je op een kaart clickt registered hij dit als kaart1 en 2 select
        private void Click_kaart(Button Buttonclick)
        {
            timer1.Stop();
            timer1.Start();
            player.SoundLocation = "flip.wav";
            player.Play();

            if (Kaart1Select == null)
            {
                Kaart1Select = Buttonclick;
            }
            else if (Kaart1Select != null && Kaart2Select == null)
            {
                Kaart2Select = Buttonclick;
            }
        }

		// Hier checkt hij of de kaart 1 en 2 select wel of niet een koppel is
        public async void Check_kaart()
        {
			// Checkt of het niet een koppel is
            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
            if (Kaart1Select != null && Kaart2Select != null)
            {
                if (Kaart1Select.Tag == Kaart2Select.Tag)
                {
                    if (Kaart1Select.Name == Kaart2Select.Name)
                    {
                        Kaart2Select = null;
                    }

					// Als het wel een koppel is
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
                        No1_Check();
                    }
                }
                else
                {
                    foreach (var x in ButtonGrid)
                    {
                        x.Enabled = false;
                    }

					// Reset cardback per thema
                    await Task.Delay(1000);
					switch (thema)
					{
						default:
							Kaart1Select.BackgroundImage = Resources.cardback;
							Kaart2Select.BackgroundImage = Resources.cardback;
							break;
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
					// Maakt kaartselect leeg en geeft de beurt aan de andere speler
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

		// Als deze wordt gecalld dan veranderd hij de beurt naar de andere speler
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

		// Deze wordt gecalld als er een match is
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

		// Dit reset de form
        private void Reset_Function()
        {
            Memory.HomePage f2 = new Memory.HomePage();
            f2.Form1reset();
            Dispose();
            GC.Collect();
        }

		// Checkt 8 punten bij 1 speler voor sound effect
		private void No1_Check()
        { 
            if (PuntenPlayer1 == 8 || PuntenPlayer2 == 8)
            {
                player.SoundLocation = "no1.wav";
                player.Play();
            }
        }

		// Checkt elke beurt of er al 8 matches zijn, want dan is de game klaar
        private async void EndGame_Check()
		{ 
			if (TotaalMatches == 8)
            {
                opslaan.Visible = false;
				if (PuntenPlayer1 > PuntenPlayer2)
                {
                    await Task.Delay(6000);
                    Reset.Visible = false;
					player.SoundLocation = "tada.wav";
                    player.Play();
                    MessageBox.Show("Gefeliciteerd " + player1 + " je hebt gewonnen!", "Einde Spel", MessageBoxButtons.OK);
                    Memory.Highscores_save.SaveData(player1, PuntenPlayer1);
                    await Task.Delay(2000);
                    player.Stop();
                }
                else if (PuntenPlayer1 == PuntenPlayer2)
                {
                    Reset.Visible = false;
                    player.SoundLocation = "wow.wav";
                    player.Play();
                    MessageBox.Show("WOW, " + player1 + " heeft gelijk gespeeld tegen " + player2 + "!" , "Einde Spel", MessageBoxButtons.OK);
                    await Task.Delay(2000);
                    player.Stop();
                }
                else
                {
                    Reset.Visible = false;
                    player.SoundLocation = "tada.wav";
                    player.Play();
                    MessageBox.Show("Gefeliciteerd " + player2 + " je hebt gewonnen!", "Einde Spel", MessageBoxButtons.OK);
                    Memory.Highscores_save.SaveData(player2, PuntenPlayer2);
                    await Task.Delay(2000);
                    player.Stop();
                }

                DialogResult ResetGame = MessageBox.Show("Willen jullie een nieuw spel spelen?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResetGame == DialogResult.Yes)
                {
                    Reset_Function();
                }
                else
                {
                    Sluiten();
                }
            }
        }
		// Hier staan alle button.clicks die de images veranderen 
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

		private void GridButton2Dub_Click(object sender, EventArgs e)
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

		private void GridButton3Dub_Click(object sender, EventArgs e)
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

		private void GridButton4Dub_Click(object sender, EventArgs e)
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

		private void GridButton5Dub_Click(object sender, EventArgs e)
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

		private void GridButton6Dub_Click(object sender, EventArgs e)
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

		// Start van game
		private void play_Click_1(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            Play_Game();
        }

		// Button om de game te resetten
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

		// Button om naar home screen te gaan
        private async void HomeButton_Click(object sender, EventArgs e)
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

		// Als je te lang niks doet encouraged met een sound om een move te maken
        private async void timer1_Tick(object sender, EventArgs e)
        {
            player.SoundLocation = "just_do_it.wav";
            player.Play();
            await Task.Delay(2000);
            player.Stop();
        }

		// Als je over de laden knop hover zie je een kleine samenvatting van wat hij dan laat
        private void laden_MouseHover(object sender, EventArgs e)
        {
            //laten zien van wat er in de save staat
            laden.Enabled = false;
            Variablen_save.Visible = true;
            string buffer = Save.LoadData();
            string buffer2 = "";
            if (buffer == "Er is nog geen\nsave file\naanwezig")
            {
                value.Text = buffer;
            }
            else
            {
                string[] savearray = buffer.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < 5; i++)
                {
                    buffer2 = (buffer2 + savearray[i] + "\n");
                }
                value.Text = buffer2;
            }
            laden.Enabled = true;
        }

		// Als je muis er af hovered dan laat hij die samenvatting niet meer zien
        private void laden_MouseLeave(object sender, EventArgs e)
        {
            bool check;
            if (laden.Enabled == false)
            {
                check = false;
            }
            else
            {
                check = true;
            }

            while (check == false)
            { }
            laden.Enabled = false;
            Variablen_save.Visible = false;
            value.Text = "";
            laden.Enabled = true;
        }

		// Sla de state van de game op zodat je hem weer kan loaden
		private async void opslaan_Click(object sender, EventArgs e)
		{
			player.SoundLocation = "click.wav";
			player.Play();
			MessageBox.Show("je spel is succesvol opgeslagen");
			string[] matcharray = new string[20];
			matchlist.CopyTo(matcharray);

			//click van deze button saved alle huidige data in .sav
			Save.SaveData(player1, player2, PuntenPlayer1, PuntenPlayer2, PlayerBeurt, TotaalMatches, matcharray, lengte);
			await Task.Delay(1000);
			player.Stop();
		}

		// Als de form geclosed wordt word hij gelijk naar het homepage geredirect
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Memory.HomePage f2 = new Memory.HomePage();
            f2.Tonen();
            Dispose();
            GC.Collect();
        }

		// Als je er op klikt dan laad hij een save die je eerder opgeslagen hebt
        private async void laden_Click(object sender, EventArgs e)
        {
            // Click van deze button load alle huidige data uit .sav
            // En zet deze in save string
            player.SoundLocation = "click.wav";
            player.Play();
            string save = Save.LoadData();
            if (save == "Er is nog geen\nsave file\naanwezig")
            { }
            else
            {
                // Save string wordt gesplit op \n en in string array gezet
                string[] savearray = save.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                // Toekennen van waarden uit array aan variabelen
                player1 = savearray[0];
                player2 = savearray[1];
                PlayerBeurt = savearray[4];
                Player1Textbox.Text = player1;
                Player2Textbox.Text = player2;

                // Aanroeping van play game
                Play_Game();

                // Score setter
                PuntenPlayer1 = int.Parse(savearray[2]);
                PuntenPlayer2 = int.Parse(savearray[3]);
                TotaalMatches = int.Parse(savearray[5]);
                Points1.Text = Convert.ToString(PuntenPlayer1);
                Points2.Text = Convert.ToString(PuntenPlayer2);
                int i = 7;
                int x = int.Parse(savearray[6] + 6);
                // Button TempButton = new Button;

                foreach (string xy in savearray)
                {
                    if (xy.Contains("GridButton"))
                    {
                        matchlist.Add(savearray[i]);
                        lengte++;

                        if (GridButton1.Name == savearray[i])
                        {
                            GridButton1.Visible = false;
                        }
                        if (GridButton1Dup.Name == savearray[i])
                        {
                            GridButton1Dup.Visible = false;
                        }
                        if (GridButton2.Name == savearray[i])
                        {
                            GridButton2.Visible = false;
                        }
                        if (GridButton2Dup.Name == savearray[i])
                        {
                            GridButton2Dup.Visible = false;
                        }
                        if (GridButton3.Name == savearray[i])
                        {
                            GridButton3.Visible = false;
                        }
                        if (GridButton3Dup.Name == savearray[i])
                        {
                            GridButton3Dup.Visible = false;
                        }
                        if (GridButton4.Name == savearray[i])
                        {
                            GridButton4.Visible = false;
                        }
                        if (GridButton4Dup.Name == savearray[i])
                        {
                            GridButton4Dup.Visible = false;
                        }
                        if (GridButton5.Name == savearray[i])
                        {
                            GridButton5.Visible = false;
                        }
                        if (GridButton5Dup.Name == savearray[i])
                        {
                            GridButton5Dup.Visible = false;
                        }
                        if (GridButton6.Name == savearray[i])
                        {
                            GridButton6.Visible = false;
                        }
                        if (GridButton6Dup.Name == savearray[i])
                        {
                            GridButton6Dup.Visible = false;
                        }
                        if (GridButton7.Name == savearray[i])
                        {
                            GridButton7.Visible = false;
                        }
                        if (GridButton7Dup.Name == savearray[i])
                        {
                            GridButton7Dup.Visible = false;
                        }
                        if (GridButton8.Name == savearray[i])
                        {
                            GridButton8.Visible = false;
                        }
                        if (GridButton8Dup.Name == savearray[i])
                        {
                            GridButton8Dup.Visible = false;
                        }
                        i++;
                    }
                }
            }
            await Task.Delay(1000);
            player.Stop();
        }  
		
		// Sluit de form
        public void Sluiten()
        {
            Close();
            Dispose();
            GC.Collect();
        }
	}
}