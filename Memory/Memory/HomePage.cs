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
            Bitmap bmp = new Bitmap(Properties.Resources.cur1031);
            Cursor c = new Cursor(bmp.GetHicon());
            this.Cursor = c;
        }

        private async void PlayButton_Click(object sender, EventArgs e)
        {
            Memory.Form4 f = new Memory.Form4();
            player.SoundLocation = "click.wav";
            player.Play();
            f.Show();
            Sluiten();
            await Task.Delay(100);
            player.Stop();
        }

        private async void SettingButton_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            Memory.SettingsPage f6 = new Memory.SettingsPage();
            f6.Show();
            await Task.Delay(300);
            player.Stop();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            Sluiten();
        }

        private async void RankButton_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            Memory.HighscorePage f7 = new Memory.HighscorePage();
            f7.Show();
            await Task.Delay(300);
            player.Stop();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            Sluiten();
        }

        public  void Sluiten()
        {
            ShowInTaskbar = false;
            Visible = false;
            Dispose();
            GC.Collect();
        }
        public void tonen()
        {
            ShowInTaskbar = true;
            Visible = true;
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Manager.ManagerInstance.Close();
            }
            else
            {

            }
        }
    }

}
