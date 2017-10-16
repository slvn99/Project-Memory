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
    public partial class Form3 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form3()
        {
            InitializeComponent();

            player.SoundLocation = "click.wav";

            bar.Controls.Add(Exit);
            Exit.BackColor = Color.Transparent;

            cat.Controls.Add(Play);
            Play.BackColor = Color.Transparent;

            cat.Controls.Add(Highscore);
            Highscore.BackColor = Color.Transparent;

            cat.Controls.Add(Load);
            Load.BackColor = Color.Transparent;

            cat.Controls.Add(Settings);
            Settings.BackColor = Color.Transparent;

            cat.Controls.Add(Memory);
            Memory.BackColor = Color.Transparent;

            bar.Controls.Add(Minimize);
            Minimize.BackColor = Color.Transparent;

            bar.Controls.Add(zwart);
            zwart.BackColor = Color.Transparent; 

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            player.Play();
            //Settings f2 = new Memory.Settings();
           // f2.instance.Show();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            player.Play();
            //gegevens ophalen
        }

        private void Highscore_Click(object sender, EventArgs e)
        {
            player.Play();
            //naar highscore pagina
        }

        private async void Play_Click(object sender, EventArgs e)
        {
            player.Play();
            Memory.Form4 f5 = new Memory.Form4();
            f5.Show();
            await Task.Delay(100);
            this.Close();
        }

        private async void Exit_Click(object sender, EventArgs e)
        {
            player.Play();
            await Task.Delay(100);
            Application.Exit();
            this.Close();
        }

        private async void Minimize_Click(object sender, EventArgs e)
        {
            player.Play();
            await Task.Delay(100);
            this.Close();
        }

        private void cat_Click(object sender, EventArgs e)
        {

        }

        private void zwart_Click(object sender, EventArgs e)
        {

        }

        private void Memory_Click(object sender, EventArgs e)
        {

        }
    }
}
