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
        string thema = Memory.SettingsPage_Save.LoadData();



        public RunningInThe90s()
        {
            InitializeComponent();


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
            Points1.Font = new Font("Arial", 8, FontStyle.Bold);
            Points1.ForeColor = System.Drawing.Color.White;
            ChangeCursor();


            void ChangeCursor()
            {
                Bitmap bmp = new Bitmap(Resources.cur1031);
                Cursor c = new Cursor(bmp.GetHicon());
                this.Cursor = c;
            }
        }

        private void PlayRunningInthe90s()
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
                Reset.Visible = true;
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
            PuntenPlayer1++;
            TotaalMatches++;
            Points1.Text = Convert.ToString(PuntenPlayer1);
            EndGame_Check();

        }

        private void Reset_Function()
        {
            //Ga terug naar begin spel                
            RunningInThe90s r2 = new RunningInThe90s();
            r2.Show();
            this.Dispose(false);
            GC.Collect();
        }     

        private void EndGame_Check()
        {
            if (TotaalMatches == 8)
            {
                MessageBox.Show("Gefeliciteerd " + player1 + " je hebt gewonnen in blablabla secondes!", "Einde Spel", MessageBoxButtons.OK);

            }



            DialogResult ResetGame = MessageBox.Show("wil je een nieuw spel spelen?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ResetGame == DialogResult.Yes)
            {
                Reset_Function();
            }
            else
            {
                //exit hoofdmenu
            }
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

        private void play_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            PlayRunningInthe90s();
        }

        #region kaarten
        private void GridButton1_Click(object sender, EventArgs e)
        {

        }

        private void GridButton1Dup_Click(object sender, EventArgs e)
        {

        }

        private void GridButton2_Click(object sender, EventArgs e)
        {

        }

        private void GridButton2Dup_Click(object sender, EventArgs e)
        {

        }

        private void GridButton3_Click(object sender, EventArgs e)
        {

        }

        private void GridButton3Dup_Click(object sender, EventArgs e)
        {

        }

        private void GridButton4_Click(object sender, EventArgs e)
        {

        }

        private void GridButton4Dup_Click(object sender, EventArgs e)
        {

        }

        private void GridButton5_Click(object sender, EventArgs e)
        {

        }

        private void GridButton5Dup_Click(object sender, EventArgs e)
        {

        }

        private void GridButton6Dup_Click(object sender, EventArgs e)
        {

        }

        private void GridButton6_Click(object sender, EventArgs e)
        {

        }

        private void GridButton7_Click(object sender, EventArgs e)
        {

        }

        private void GridButton7Dup_Click(object sender, EventArgs e)
        {

        }

        private void GridButton8_Click(object sender, EventArgs e)
        {

        }

        private void GridButton8Dup_Click(object sender, EventArgs e)
        {

        }
        #endregion

        public void Saveclass_Click(object sender, EventArgs e)
        {
            string[] matcharray = new string[20];
            matchlist.CopyTo(matcharray);

            //click van deze button saved alle huidige data in .sav

        }


        private void Loadclass_MouseLeave(object sender, EventArgs e)
        {
            //idem
            Variablen_save.Visible = false;
            value.Text = "";
        }
        public void Sluiten()
        {
            Close();
            Dispose();
            GC.Collect();
        }
    }

}


