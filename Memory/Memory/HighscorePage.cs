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
            Standaard_gamemode.Visible = true;
            Running_gamemode.Visible = false;

            if (save == "Er is nog geen\nsave file\naanwezig")
            {
            }

            else
            {
                
                //save string wordt gesplit op \n en in string array gezet
                string[] savearray = save.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                //toekennen van waarden uit array aan variabelen

                for(int i = 0;i<savearray.Length;i++)
                {
                    if (savearray[i] != null)
                    {
                        var position = i +1;
                        var labels = Controls.Find("label" + position, true);
                        if(labels.Length > 0)
                        {
                            var label = (Label)labels[0];
                            label.Text = savearray[i];
                        }
                    }
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
                RunningSave.Reset();
                this.Close();
            }

            await Task.Delay(1000);
            player.Stop();
        }

        //Het tonen van de Highscorepage aangepast op de gamemode
        private async void switch_gamemode_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            await Task.Delay(300);
            player.Stop();
            if (Gamemodelabel.Text == "Standard Gamemode")
            {
                string save = RunningSave.LoadData();
                Gamemodelabel.Text = "Running Gamemode";
                Standaard_gamemode.Visible = true;
                Running_gamemode.Visible = false;

                if (save == "Er is nog geen\nsave file\naanwezig")
                {
                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            var position = i + 1;
                            var labels = Controls.Find("label" + position, true);
                            if (labels.Length > 0)
                            {
                                var label = (Label)labels[0];
                                label.Text = "";
                            }
                        }
                        catch
                        {

                        }
                    }
                }

                else
                {

                    //save string wordt gesplit op \n en in string array gezet
                    string[] savearray = save.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    //toekennen van waarden uit array aan variabelen

                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            if (savearray[i] != null)
                            {
                                var position = i + 1;
                                var labels = Controls.Find("label" + position, true);
                                if (labels.Length > 0)
                                {
                                    var label = (Label)labels[0];
                                    label.Text = savearray[i];
                                }
                            }
                        }
                        catch
                        {
                            var position = i + 1;
                            var labels = Controls.Find("label" + position, true);
                            if (labels.Length > 0)
                            {
                                var label = (Label)labels[0];
                                label.Text = "";
                            }
                        }
                    }
                }
            }

            else if (Gamemodelabel.Text == "Running Gamemode")
            {
                string save = Highscores_save.LoadData();
                Gamemodelabel.Text = "Standard Gamemode";
                Standaard_gamemode.Visible = false;
                Running_gamemode.Visible = true;

                if (save == "Er is nog geen\nsave file\naanwezig")
                {
                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            var position = i + 1;
                            var labels = Controls.Find("label" + position, true);
                            if (labels.Length > 0)
                            {
                                var label = (Label)labels[0];
                                label.Text = "";
                            }
                        }
                        catch
                        {

                        }
                    }
                }

                else
                {

                    //save string wordt gesplit op \n en in string array gezet
                    string[] savearray = save.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    //toekennen van waarden uit array aan variabelen

                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            if (savearray[i] != null)
                            {
                                var position = i + 1;
                                var labels = Controls.Find("label" + position, true);
                                if (labels.Length > 0)
                                {
                                    var label = (Label)labels[0];
                                    label.Text = savearray[i];
                                }
                            }
                        }
                        catch
                        {
                            var position = i + 1;
                            var labels = Controls.Find("label" + position, true);
                            if (labels.Length > 0)
                            {
                                var label = (Label)labels[0];
                                label.Text = "";
                            }
                        }
                    }
                }
            }
        }
    }
}
