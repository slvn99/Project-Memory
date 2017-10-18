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
    public partial class HomePage : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public HomePage()
        {
            InitializeComponent();

            pictureBox1.Controls.Add(tableLayoutPanel1);
            tableLayoutPanel1.BackColor = Color.Transparent;

            pictureBox1.Controls.Add(tableLayoutPanel2);
            tableLayoutPanel2.BackColor = Color.Transparent;

            ChangeCursor();
        }

        void ChangeCursor()
        {
            Bitmap bmp = new Bitmap(Properties.Resources.mouse_xs);
            Cursor c = new Cursor(bmp.GetHicon());
            this.Cursor = c;
        }

        private async void PlayButton_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            Memory.Form4 f5 = new Memory.Form4();
            f5.Show();
            await Task.Delay(1000);
            this.Hide();
        }

        private async void SettingButton_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            Memory.SettingsPage f6 = new Memory.SettingsPage();
            f6.Show();
            await Task.Delay(100);
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private async void RankButton_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            Memory.HighscorePage f7 = new Memory.HighscorePage();
            f7.Show();
            await Task.Delay(100);
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
