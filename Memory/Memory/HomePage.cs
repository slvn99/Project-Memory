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
            StandardGamemode.Visible = false;
            RunningGamemode.Visible = false;
            Backbutton.Visible = false;

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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public  void Sluiten()
        {
            ShowInTaskbar = false;
            Visible = false;
            Dispose();
            GC.Collect();
            Close();
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
                Application.Exit();
                Manager.ManagerInstance.Close();
            }
            else
            {

            }
        }
        public void form1reset()
        {
            WindowsFormsApp1.Form1 f = new WindowsFormsApp1.Form1();
            f.Show();
            Sluiten();
        }

        private async void PlayButton_Click(object sender, EventArgs e)
        {

            player.SoundLocation = "click.wav";
            player.Play();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            RankButton.Visible = false;
            PlayButton.Visible = false;
            SettingButton.Visible = false;
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel5.Visible = false;
            StandardGamemode.Visible = true;
            RunningGamemode.Visible = true;
            Backbutton.Visible = true;
            await Task.Delay(100);
            player.Stop();
        }

        private async void Backbutton_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            RankButton.Visible = true;
            PlayButton.Visible = true;
            SettingButton.Visible = true;
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel3.Visible = true;
            tableLayoutPanel4.Visible = true;
            tableLayoutPanel5.Visible = true;
            StandardGamemode.Visible = false;
            RunningGamemode.Visible = false;
            Backbutton.Visible = false;
            await Task.Delay(100);
            player.Stop();
        }

        private void RunningGamemode_Click(object sender, EventArgs e)
        {
            Memory.RunningInThe90s f1 = new Memory.RunningInThe90s();
            f1.Show();
            Sluiten();
        }

        private void StandardGamemode_Click_1(object sender, EventArgs e)
        {
            Memory.Form4 f = new Memory.Form4();
            f.Show();
            Sluiten();
        }
    }

}
