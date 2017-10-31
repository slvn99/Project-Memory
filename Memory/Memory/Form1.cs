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
    public partial class Form1 : Form 
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
            opslaan.Visible = false;

			//if (thema == "Er is nog geen\nsave file\naanwezig")
			//{ }
			//else
			//{
			//	switch (thema)
			//	{
			//		case "Steam":
			//			GridButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton1.BackgroundImage = Resources.Steam;
			//			GridButton1Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton1Dup.BackgroundImage = Resources.Steam;
			//			GridButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton2.BackgroundImage = Resources.TwitchLogo;
			//			GridButton2Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton2Dup.BackgroundImage = Resources.TwitchLogo;
			//			GridButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton3.BackgroundImage = Resources.fb;
			//			GridButton3Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton3Dup.BackgroundImage = Resources.fb;
			//			GridButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton4.BackgroundImage = Resources.Reddit;
			//			GridButton4Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton4Dup.BackgroundImage = Resources.Reddit;
			//			GridButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton5.BackgroundImage = Resources._9gag;
			//			GridButton5Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton5Dup.BackgroundImage = Resources._9gag;
			//			GridButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton6.BackgroundImage = Resources.Twitter;
			//			GridButton6Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton6Dup.BackgroundImage = Resources.Twitter;
			//			GridButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton7.BackgroundImage = Resources.Youtube;
			//			GridButton7Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton7Dup.BackgroundImage = Resources.Youtube;
			//			GridButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton8.BackgroundImage = Resources.Google;
			//			GridButton8Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton8Dup.BackgroundImage = Resources.Google;
			//			break;
			//		case "Twitch":
			//			GridButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton1.BackgroundImage = Resources.Steam;
			//			GridButton1Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton1Dup.BackgroundImage = Resources.Steam;
			//			GridButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton2.BackgroundImage = Resources.TwitchLogo;
			//			GridButton2Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton2Dup.BackgroundImage = Resources.TwitchLogo;
			//			GridButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton3.BackgroundImage = Resources.fb;
			//			GridButton3Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton3Dup.BackgroundImage = Resources.fb;
			//			GridButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton4.BackgroundImage = Resources.Reddit;
			//			GridButton4Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton4Dup.BackgroundImage = Resources.Reddit;
			//			GridButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton5.BackgroundImage = Resources._9gag;
			//			GridButton5Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton5Dup.BackgroundImage = Resources._9gag;
			//			GridButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton6.BackgroundImage = Resources.Twitter;
			//			GridButton6Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton6Dup.BackgroundImage = Resources.Twitter;
			//			GridButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton7.BackgroundImage = Resources.Youtube;
			//			GridButton7Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton7Dup.BackgroundImage = Resources.Youtube;
			//			GridButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton8.BackgroundImage = Resources.Google;
			//			GridButton8Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton8Dup.BackgroundImage = Resources.Google;
			//			break;
			//		case "Reddit":
			//			GridButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton1.BackgroundImage = Resources.Reddit;
			//			//GridButton1.Click = GridButton1.BackgroundImage = Resources.Reddit;
			//			GridButton1Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton1Dup.BackgroundImage = Resources.Reddit;
			//			GridButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton2.BackgroundImage = Resources.Reddit;
			//			GridButton2Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton2Dup.BackgroundImage = Resources.Reddit;
			//			GridButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton3.BackgroundImage = Resources.Reddit;
			//			GridButton3Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton3Dup.BackgroundImage = Resources.Reddit;
			//			GridButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton4.BackgroundImage = Resources.Reddit;
			//			GridButton4Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton4Dup.BackgroundImage = Resources.Reddit;
			//			GridButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton5.BackgroundImage = Resources.Reddit;
			//			GridButton5Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton5Dup.BackgroundImage = Resources.Reddit;
			//			GridButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton6.BackgroundImage = Resources.Reddit;
			//			GridButton6Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton6Dup.BackgroundImage = Resources.Reddit;
			//			GridButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton7.BackgroundImage = Resources.Reddit;
			//			GridButton7Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton7Dup.BackgroundImage = Resources.Reddit;
			//			GridButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton8.BackgroundImage = Resources.Reddit;
			//			GridButton8Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton8Dup.BackgroundImage = Resources.Reddit;
			//			break;
			//		default:
			//			GridButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton1.BackgroundImage = Resources.Steam;
			//			GridButton1Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton1Dup.BackgroundImage = Resources.Steam;
			//			GridButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton2.BackgroundImage = Resources.TwitchLogo;
			//			GridButton2Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton2Dup.BackgroundImage = Resources.TwitchLogo;
			//			GridButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton3.BackgroundImage = Resources.fb;
			//			GridButton3Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton3Dup.BackgroundImage = Resources.fb;
			//			GridButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton4.BackgroundImage = Resources.Reddit;
			//			GridButton4Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton4Dup.BackgroundImage = Resources.Reddit;
			//			GridButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton5.BackgroundImage = Resources._9gag;
			//			GridButton5Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton5Dup.BackgroundImage = Resources._9gag;
			//			GridButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton6.BackgroundImage = Resources.Twitter;
			//			GridButton6Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton6Dup.BackgroundImage = Resources.Twitter;
			//			GridButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton7.BackgroundImage = Resources.Youtube;
			//			GridButton7Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton7Dup.BackgroundImage = Resources.Youtube;
			//			GridButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton8.BackgroundImage = Resources.Google;
			//			GridButton8Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			//			GridButton8Dup.BackgroundImage = Resources.Google;
			//			break;
			//	}
			//}
			ChangeCursor();
            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
            foreach (var x in ButtonGrid)
            {
                x.Visible = false;
                punten.Add(x.Location);
                x.Text = "";
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

        void ChangeCursor()
        {
            Bitmap bmp = new Bitmap (Resources.cur1031);
            Cursor c = new Cursor(bmp.GetHicon());
            this.Cursor = c;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
             GC.Collect();
            Play_Game();
            
        }

        private void Play_Game()
        {
            if (Player1Textbox.Text == "" || Player2Textbox.Text == "")
            {
                MessageBox.Show("Je moet een naam invullen!");
            }
			if (Player1Textbox.Text == Player2Textbox.Text)
			{
				MessageBox.Show("Voer 2 verschillende namen in");
			}

            else
            {
                Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
               
                foreach (var x in ButtonGrid)
                {
                    x.Visible = true;
                }
                
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
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
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
                    Kaart1Select.BackgroundImage = Resources.cardback;
                    Kaart2Select.BackgroundImage = Resources.cardback;
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

        private void Reset_Function()
        {
            Memory.HomePage f2 = new Memory.HomePage();
            f2.form1reset();
            Dispose();
            GC.Collect();
        }

        private void EndGame_Check()
        {
            if (TotaalMatches == 8)
            {
                opslaan.Visible = false;
                if (PuntenPlayer1 > PuntenPlayer2)
                {
                    MessageBox.Show("Gefeliciteerd " + player1 + " je hebt gewonnen!", "Einde Spel", MessageBoxButtons.OK);
                    Memory.Highscores_save.SaveData(player1, PuntenPlayer1);
                }
                else if (PuntenPlayer1 == PuntenPlayer2)
                {
                    MessageBox.Show("WOW, " + player1 + " heeft gelijk gespeeld met " + player2 + "!" , "Einde Spel", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Gefeliciteerd " + player2 + " je hebt gewonnen!", "Einde Spel", MessageBoxButtons.OK);
                    Memory.Highscores_save.SaveData(player2, PuntenPlayer2);
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

		#region kaarten
		private void GridButton1_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton1.BackgroundImage = Resources.Steam;
					break;
				case "Films":
					GridButton1.BackgroundImage = Resources.ff130;
					break;
				case "Games":
					GridButton1.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton1);
			Check_kaart();
		}

		private void GridButton1Dup_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton1Dup.BackgroundImage = Resources.Steam;
					break;
				case "Films":
					GridButton1Dup.BackgroundImage = Resources.ff130;
					break;
				case "Games":
					GridButton1Dup.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton1Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton1Dup);
			Check_kaart();
		}

		private void GridButton2_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton2.BackgroundImage = Resources.fb;
				break;
				case "Films":
					GridButton2.BackgroundImage = Resources.hp130;
				break;
				case "Games":
					GridButton2.BackgroundImage = Resources.Tyfusding;
				break;
			}
			GridButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton2);
			Check_kaart();
		}

		private void GridButton2Dub_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton2Dup.BackgroundImage = Resources.fb;
					break;
				case "Films":
					GridButton2Dup.BackgroundImage = Resources.hp130;
					break;
				case "Games":
					GridButton2Dup.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton2Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton2Dup);
			Check_kaart();
		}

		private void GridButton3_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton3.BackgroundImage = Resources.Google;
					break;
				case "Films":
					GridButton3.BackgroundImage = Resources.shrek130;
					break;
				case "Games":
					GridButton3.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton3);
			Check_kaart();
		}

		private void GridButton3Dub_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton3Dup.BackgroundImage = Resources.Google;
					break;
				case "Films":
					GridButton3Dup.BackgroundImage = Resources.shrek130;
					break;
				case "Games":
					GridButton3Dup.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton3Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton3Dup);
			Check_kaart();
		}

		private void GridButton4_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton4.BackgroundImage = Resources.Youtube;
					break;
				case "Films":
					GridButton4.BackgroundImage = Resources.indiana130;
					break;
				case "Games":
					GridButton4.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton4);
			Check_kaart();
		}

		private void GridButton4Dub_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton4Dup.BackgroundImage = Resources.Youtube;
					break;
				case "Films":
					GridButton4Dup.BackgroundImage = Resources.indiana130;
					break;
				case "Games":
					GridButton4Dup.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton4Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton4Dup);
			Check_kaart();
		}

		private void GridButton5_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton5.BackgroundImage = Resources.Twitter;
					break;
				case "Films":
					GridButton5.BackgroundImage = Resources.lotr_130;
					break;
				case "Games":
					GridButton5.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton5);
			Check_kaart();
		}

		private void GridButton5Dub_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton5Dup.BackgroundImage = Resources.Twitter;
					break;
				case "Films":
					GridButton5Dup.BackgroundImage = Resources.lotr_130;
					break;
				case "Games":
					GridButton5Dup.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton5Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton5Dup);
			Check_kaart();
		}

		private void GridButton6_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton6.BackgroundImage = Resources._9gag;
					break;
				case "Films":
					GridButton6.BackgroundImage = Resources.avengers130;
					break;
				case "Games":
					GridButton6.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton6);
			Check_kaart();
		}

		private void GridButton6Dub_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton6Dup.BackgroundImage = Resources._9gag;
					break;
				case "Films":
					GridButton6Dup.BackgroundImage = Resources.avengers130;
					break;
				case "Games":
					GridButton6Dup.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton6Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton6Dup);
			Check_kaart();
		}

		private void GridButton7_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton7.BackgroundImage = Resources.TwitchLogo;
					break;
				case "Films":
					GridButton7.BackgroundImage = Resources.star_trek130;
					break;
				case "Games":
					GridButton7.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton7);
			Check_kaart();
		}

		private void GridButton7Dup_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton7Dup.BackgroundImage = Resources.TwitchLogo;
					break;
				case "Films":
					GridButton7Dup.BackgroundImage = Resources.star_trek130;
					break;
				case "Games":
					GridButton7Dup.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton7Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton7Dup);
			Check_kaart();
		}

		private void GridButton8_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton8.BackgroundImage = Resources.Reddit;
					break;
				case "Films":
					GridButton8.BackgroundImage = Resources.starwars130;
					break;
				case "Games":
					GridButton8.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton8);
			Check_kaart();
		}

		private void GridButton8Dup_Click(object sender, EventArgs e)
		{
			switch (thema)
			{
				case "Media":
					GridButton8Dup.BackgroundImage = Resources.Reddit;
					break;
				case "Films":
					GridButton8Dup.BackgroundImage = Resources.starwars130;
					break;
				case "Games":
					GridButton8Dup.BackgroundImage = Resources.Tyfusding;
					break;
			}
			GridButton8Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			Click_kaart(GridButton8Dup);
			Check_kaart();
		}
		#endregion

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void play_Click_1(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            Play_Game();
        }

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Memory.HomePage f2 = new Memory.HomePage();
            f2.tonen();
            Dispose();
            GC.Collect();
        }

        private void laden_Click(object sender, EventArgs e)
        {
            //click van deze button load alle huidige data uit .sav
            //en zet deze in save string
            string save = Save.LoadData();
            if (save == "Er is nog geen\nsave file\naanwezig")
            { }
            else
            {
                //save string wordt gesplit op \n en in string array gezet
                string[] savearray = save.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                //toekennen van waarden uit array aan variabelen
                player1 = savearray[0];
                player2 = savearray[1];
                PlayerBeurt = savearray[4];
                Player1Textbox.Text = player1;
                Player2Textbox.Text = player2;

                //aanroeping van play game
                Play_Game();

                //Score setter
                PuntenPlayer1 = int.Parse(savearray[2]);
                PuntenPlayer2 = int.Parse(savearray[3]);
                TotaalMatches = int.Parse(savearray[5]);
                Points1.Text = Convert.ToString(PuntenPlayer1);
                Points2.Text = Convert.ToString(PuntenPlayer2);
                int i = 7;
                int x = int.Parse(savearray[6] + 6);
                //Button TempButton = new Button;

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
        }


        private void opslaan_Click(object sender, EventArgs e)
        {
            string[] matcharray = new string[20];
            matchlist.CopyTo(matcharray);

            //click van deze button saved alle huidige data in .sav
            Save.SaveData(player1, player2, PuntenPlayer1, PuntenPlayer2, PlayerBeurt, TotaalMatches, matcharray, lengte);
        }     

        public void Sluiten()
        {
            Close();
            Dispose();
            GC.Collect();
        }
    }

}