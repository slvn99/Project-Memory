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
    public partial class HighscorePage : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public HighscorePage()
        {
            InitializeComponent();
            string save = Highscores_save.LoadData();
            string runningsave = RunningSave.LoadData();
            Gamemodelabel.Text = "Standard Gamemode";

            if (save == "Er is nog geen\nsave file\naanwezig")
            {
            }

            else
            {
                
                //save string wordt gesplit op \n en in string array gezet
                string[] savearray = save.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                //toekennen van waarden uit array aan variabelen
                try
                {
                    if (savearray[0] != null)
                    {
                        label1.Text = savearray[0];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[1] != null)
                    {
                        label2.Text = savearray[1];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[2] != null)
                    {
                        label3.Text = savearray[2];
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    if (savearray[3] != null)
                    {
                        label4.Text = savearray[3];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[4] != null)
                    {
                        label5.Text = savearray[4];
                    }
                }

                catch (Exception)
                {
                }

                try
                {
                    if (savearray[5] != null)
                    {
                        label6.Text = savearray[5];
                    }
                }

                catch (Exception)
                {
                }

                try
                {
                    if (savearray[6] != null)
                    {
                        label7.Text = savearray[6];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[7] != null)
                    {
                        label8.Text = savearray[7];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[8] != null)
                    {
                        label9.Text = savearray[8];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[9] != null)
                    {
                        label10.Text = savearray[9];
                    }
                }
                catch (Exception)
                {
                }

                ChangeCursor();
            }

            //methode die de mousecursor aanpast
            void ChangeCursor()
            {
                Bitmap bmp = new Bitmap(Properties.Resources.cur1031);
                Cursor c = new Cursor(bmp.GetHicon());
                this.Cursor = c;
            }

            label1.ForeColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.White;
            label3.ForeColor = System.Drawing.Color.White;
            label4.ForeColor = System.Drawing.Color.White;
            label5.ForeColor = System.Drawing.Color.White;
            label6.ForeColor = System.Drawing.Color.White;
            label7.ForeColor = System.Drawing.Color.White;
            label8.ForeColor = System.Drawing.Color.White;
            label9.ForeColor = System.Drawing.Color.White;
            label10.ForeColor = System.Drawing.Color.White;

        }

        //event die je terugstuurt naar de Homepage wanneer de highscore form gesloten is
		private void HighscorePage_FormClosed(object sender, FormClosedEventArgs e)
		{
			Memory.HomePage f2 = new Memory.HomePage();
			f2.Show();
		}

        //Het terugsturen naar het hoofdmenu vanuit de highscorepage
        private async void HomeButton_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            await Task.Delay(300);
            player.Stop();
            this.Close();
        }

        //magische code
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
				return cp;
			}
		}

        //Resetfunctie voor de highscores
		private async void Hsreset_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            DialogResult ExitGame = MessageBox.Show("Weet je zeker dat je de highscores wilt resetten? ", "Reset", MessageBoxButtons.YesNo);

            if (ExitGame == DialogResult.Yes)
            {
                Highscores_save.Reset();
                this.Close();
            }

            await Task.Delay(1000);
            player.Stop();
        }

        //Het tonen van de Highscorepage aangepast op de gamemode
        private void Listswitchbutton_Click(object sender, EventArgs e)
        {
            if (Gamemodelabel.Text == "Standard Gamemode")
            {
                Gamemodelabel.Text = "Running Gamemode";
                string save = Highscores_save.LoadData();
                string runningsave = RunningSave.LoadData();

                //save string wordt gesplit op \n en in string array gezet
                string[] savearray = runningsave.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                //toekennen van waarden uit array aan variabelen
                try
                {
                    if (savearray[0] != null)
                    {
                        label1.Text = savearray[0];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[1] != null)
                    {
                        label2.Text = savearray[1];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[2] != null)
                    {
                        label3.Text = savearray[2];
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    if (savearray[3] != null)
                    {
                        label4.Text = savearray[3];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[4] != null)
                    {
                        label5.Text = savearray[4];
                    }
                }

                catch (Exception)
                {
                }

                try
                {
                    if (savearray[5] != null)
                    {
                        label6.Text = savearray[5];
                    }
                }

                catch (Exception)
                {
                }

                try
                {
                    if (savearray[6] != null)
                    {
                        label7.Text = savearray[6];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[7] != null)
                    {
                        label8.Text = savearray[7];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[8] != null)
                    {
                        label9.Text = savearray[8];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[9] != null)
                    {
                        label10.Text = savearray[9];
                    }
                }
                catch (Exception)
                {
                }
            }

            else if (Gamemodelabel.Text == "Running Gamemode")
            {
                Gamemodelabel.Text = "Standard Gamemode";
                string save = Highscores_save.LoadData();
                string runningsave = RunningSave.LoadData();

                //save string wordt gesplit op \n en in string array gezet
                string[] savearray = save.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                //toekennen van waarden uit array aan variabelen
                try
                {
                    if (savearray[0] != null)
                    {
                        label1.Text = savearray[0];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[1] != null)
                    {
                        label2.Text = savearray[1];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[2] != null)
                    {
                        label3.Text = savearray[2];
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    if (savearray[3] != null)
                    {
                        label4.Text = savearray[3];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[4] != null)
                    {
                        label5.Text = savearray[4];
                    }
                }

                catch (Exception)
                {
                }

                try
                {
                    if (savearray[5] != null)
                    {
                        label6.Text = savearray[5];
                    }
                }

                catch (Exception)
                {
                }

                try
                {
                    if (savearray[6] != null)
                    {
                        label7.Text = savearray[6];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[7] != null)
                    {
                        label8.Text = savearray[7];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[8] != null)
                    {
                        label9.Text = savearray[8];
                    }
                }
                catch (Exception)
                {
                }

                try
                {
                    if (savearray[9] != null)
                    {
                        label10.Text = savearray[9];
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
