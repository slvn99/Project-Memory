using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Memory
{
	public partial class SettingsPage : Form
	{
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);


        public static string SetValueForComboBox = "";
		System.Media.SoundPlayer player = new System.Media.SoundPlayer();
		public SettingsPage()
		{
			InitializeComponent();

            ChangeCursor();
		}

        void ChangeCursor()
        {
            Bitmap bmp = new Bitmap(Properties.Resources.mouse_xs);
            Cursor c = new Cursor(bmp.GetHicon());
            this.Cursor = c;
        }

		private async void HomeButton_Click_1(object sender, EventArgs e)
		{
			player.SoundLocation = "click.wav";
			player.Play();
			await Task.Delay(300);
			player.Stop();
			this.Close();
			this.ShowInTaskbar = false;
		}

		public async void Apply_Click(object sender, EventArgs e)
		{
			player.SoundLocation = "click.wav";
			player.Play();
			Memory.HomePage f2 = new Memory.HomePage();
			f2.Show();
			await Task.Delay(300);
			player.Stop();
			Memory.SettingsPage_Save.SaveData(ThemaBox.SelectedText);
		}

		private async void SettingsPage_FormClosed(object sender, FormClosedEventArgs e)
		{
			Memory.HomePage f13 = new Memory.HomePage();
			f13.Show();
			await Task.Delay(100);
			this.Close();
		}

		private void VolumeDown_Click(object sender, EventArgs e)
		{
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);

        }

        private void VolumeUp_Click(object sender, EventArgs e)
		{
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private async void Home_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "click.wav";
            player.Play();
            await Task.Delay(300);
            player.Stop();
            this.Close();
            this.ShowInTaskbar = false;
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);

        }
    }
}
