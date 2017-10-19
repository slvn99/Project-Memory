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
	public partial class SettingsPage : Form
	{
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

        public void ThemaBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ThemaBox.SelectedText == "Thema 1")
			{
				// Als thema 1 gepickt wordt, dan moet het thema 1 gebruiken als cards
			}

			if (ThemaBox.SelectedText == "Thema 2")
			{
				// Als thema 2 gepickt wordt, dan moet het thema 2 gebruiken als cards
			}

			if (ThemaBox.SelectedText == "Thema 3")
			{
				// Als thema 3 gepickt wordt, dan moet het thema 3 gebruiken als cards
			}
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

		}

		private void VolumeUp_Click(object sender, EventArgs e)
		{

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
    }
}
