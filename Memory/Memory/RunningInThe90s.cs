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
        Random ButtonLocatie = new Random();



        public RunningInThe90s()
        {
            InitializeComponent();


            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
            foreach (var x in ButtonGrid)
            {
                x.Visible = false;
                punten.Add(x.Location);
            }

            foreach (Button Button in ButtonGrid)
            {
                int next = ButtonLocatie.Next(punten.Count);
                Point p = punten[next];
                Button.Location = p;
                punten.Remove(p);
                Button.Text = "[=]";
            }

            Player1LabelInvoer.Font = new Font("Arial", 8, FontStyle.Bold);
            Player1LabelInvoer.ForeColor = System.Drawing.Color.White;
            Points1.Font = new Font("Arial", 8, FontStyle.Bold);
            Points1.ForeColor = System.Drawing.Color.White;

        }



        private void PlayButton_Click(object sender, EventArgs e)
        {
           RunningInthe90s();
        }

        private void RunningInthe90s()
        {
            if (Player1Textbox.Text == "")
            {
                MessageBox.Show("Je moet een naam invullen!");
            }

            else
            {
                Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };

                foreach (var x in ButtonGrid)
                {
                    x.Visible = true;
                }

                PuntenPlayer1 = 0;
                TotaalMatches = 0;
                Points1.Text = Convert.ToString(PuntenPlayer1);
                Player1Textbox.Visible = false;
                Player1LabelInvoer.Visible = true;
                Points1.Visible = true;
                Saveclass.Visible = true;
                Speler1.Visible = true;
                pictureBox1.Visible = false;
                Speler1.Visible = true;
                play.Visible = false;

                Player1LabelInvoer.Text = Player1Textbox.Text;

                player1 = Player1LabelInvoer.Text;
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

        public void Check_kaart()
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

                        clearcards1();

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

                    clearcards2();

                    foreach (var x in ButtonGrid)
                    {
                        x.Enabled = true;
                    }
                }
            }
        }


        private void Point_Add()
        {
            PuntenPlayer1++;
            TotaalMatches++;
            Points1.Text = Convert.ToString(PuntenPlayer1);
            EndGame_Check();

        }

        private void Reset_Function()
        {
            //Ga terug naar begin spel                
            PuntenPlayer1 = 0;
            Points1.Text = "0";
            Points1.Visible = false;
            Kaart1Select = null;
            Kaart2Select = null;
            Player1Textbox.Visible = true;
            Player1Textbox.Text = string.Empty;
            Player1LabelInvoer.Visible = false;
            Speler1.Visible = false;
            play.Visible = true;
            pictureBox1.Visible = true;
            GridButton1.Visible = true;

            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };

            foreach (var x in ButtonGrid)
            {
                x.Visible = false;
            }
            foreach (var x in ButtonGrid)
            {
                x.Text = "[=]";
            }
        }

        private void EndGame_Check()
        {
            if (TotaalMatches == 8)
            {
                MessageBox.Show("Gefeliciteerd " + player1 + " je hebt gewonnen in blablabla secondes!", "Einde Spel", MessageBoxButtons.OK);

            }



            DialogResult ResetGame = MessageBox.Show("Willen jullie een nieuw spel spelen?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ResetGame == DialogResult.Yes)
            {
                Reset_Function();
            }
            else
            {
                //exit hoofdmenu
            }
        }


        #region kaarten
        private void GridButton1_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.Steam;
            GridButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton1.BackgroundImage = myimage;
            GridButton1.Text = "";
            Click_kaart(GridButton1);
            Check_kaart();
        }

        private void GridButton1Dup_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.Steam;
            GridButton1Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton1Dup.BackgroundImage = myimage;
            GridButton1Dup.Text = "";
            Click_kaart(GridButton1Dup);
            Check_kaart();
        }

        private void GridButton2_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.TwitchLogo;
            GridButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton2.BackgroundImage = myimage;
            GridButton2.Text = "";
            Click_kaart(GridButton2);
            Check_kaart();
        }

        private void GridButton2Dub_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.TwitchLogo;
            GridButton2Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton2Dup.BackgroundImage = myimage;
            GridButton2Dup.Text = "";
            Click_kaart(GridButton2Dup);
            Check_kaart();
        }

        private void GridButton3_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.fb;
            GridButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton3.BackgroundImage = myimage;
            GridButton3.Text = "";
            Click_kaart(GridButton3);
            Check_kaart();
        }

        private void GridButton3Dub_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.fb;
            GridButton3Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton3Dup.BackgroundImage = myimage;
            GridButton3Dup.Text = "";
            Click_kaart(GridButton3Dup);
            Check_kaart();
        }

        private void GridButton4_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.Reddit;
            GridButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton4.BackgroundImage = myimage;
            GridButton4.Text = "";
            Click_kaart(GridButton4);
            Check_kaart();
        }

        private void GridButton4Dub_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.Reddit;
            GridButton4Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton4Dup.BackgroundImage = myimage;
            GridButton4Dup.Text = "";
            Click_kaart(GridButton4Dup);
            Check_kaart();
        }

        private void GridButton5_Click(object sender, EventArgs e)
        {
            Image myimage = Resources._9gag;
            GridButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton5.BackgroundImage = myimage;
            GridButton5.Text = "";
            Click_kaart(GridButton5);
            Check_kaart();
        }

        private void GridButton5Dub_Click(object sender, EventArgs e)
        {
            Image myimage = Resources._9gag;
            GridButton5Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton5Dup.BackgroundImage = myimage;
            GridButton5Dup.Text = "";
            Click_kaart(GridButton5Dup);
            Check_kaart();
        }

        private void GridButton6_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.Twitter;
            GridButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton6.BackgroundImage = myimage;
            GridButton6.Text = "";
            Click_kaart(GridButton6);
            Check_kaart();
        }

        private void GridButton6Dub_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.Twitter;
            GridButton6Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton6Dup.BackgroundImage = myimage;
            GridButton6Dup.Text = "";
            Click_kaart(GridButton6Dup);
            Check_kaart();
        }

        private void GridButton7_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.Youtube;
            GridButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton7.BackgroundImage = myimage;
            GridButton7.Text = "";
            Click_kaart(GridButton7);
            Check_kaart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GridButton7Dup_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.Youtube;
            GridButton7Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton7Dup.BackgroundImage = myimage;
            GridButton7Dup.Text = "";
            Click_kaart(GridButton7Dup);
            Check_kaart();
        }

        private void GridButton8_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.Google;
            GridButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton8.BackgroundImage = myimage;
            GridButton8.Text = "";
            Click_kaart(GridButton8);
            Check_kaart();
        }

        private void GridButton8Dup_Click(object sender, EventArgs e)
        {
            Image myimage = Resources.Google;
            GridButton8Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            GridButton8Dup.BackgroundImage = myimage;
            GridButton8Dup.Text = "";
            Click_kaart(GridButton8Dup);
            Check_kaart();
        }
        #endregion

        private void play_Click_1(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            RunningInthe90s();
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult ResetGame = MessageBox.Show("Weet je zeker dat je opnieuw wilt beginnen? Je voortgang zal verloren gaan", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ResetGame == DialogResult.Yes)
            {
                Reset_Function();
            }
            else
            {
                //return hoofdmenu.
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            await Task.Delay(300);
            player.Stop();
            this.Close();
            this.ShowInTaskbar = false;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Memory.HomePage f2 = new Memory.HomePage();
            f2.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult ExitGame = MessageBox.Show("Weet u zeker dat u het spel wil verlaten? Onopgeslagen progressie zal verloren gaan! ", "Exit", MessageBoxButtons.YesNo);

            if (ExitGame == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void Saveclass_Click(object sender, EventArgs e)
        {
            string[] matcharray = new string[20];
            matchlist.CopyTo(matcharray);

            //click van deze button saved alle huidige data in .sav

        }

        private void play_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            RunningInthe90s();
        }

        private void Loadclass_MouseLeave(object sender, EventArgs e)
        {
            //idem
            Variablen_save.Visible = false;
            value.Text = "";
        }

        public async void clearcards1()
        {
            await Task.Delay(1000);
            Kaart1Select.Visible = false;
            Kaart2Select.Visible = false;
            Kaart1Select = null;
            Kaart2Select = null;
            Point_Add();
        }

        public async void clearcards2()
        {
            await Task.Delay(1000);
            Kaart1Select.Text = "[=]";
            Kaart2Select.Text = "[=]";

            Kaart1Select = null;
            Kaart2Select = null;

        }
    }

}


