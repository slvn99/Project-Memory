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

		private void MuteButton_Click(object sender, EventArgs e)
		{
			//Jorden maar ff doen ofzo geen idee hoe het met de music zit
		}

		private void SpeakerButton_Click(object sender, EventArgs e)
		{
			//Jorden maar ff doen ofzo geen idee hoe het met de music zit
		}

		private async void HomeButton_Click_1(object sender, EventArgs e)
		{
			player.SoundLocation = "click.wav";
			player.Play();
			Memory.HomePage f2 = new Memory.HomePage();
			f2.Show();
			await Task.Delay(100);
			this.WindowState = FormWindowState.Minimized;
			this.ShowInTaskbar = false;
		}

		public void Apply_Click(object sender, EventArgs e)
		{
			SetValueForComboBox = ThemaBox.SelectedText;
			MessageBox.Show(SetValueForComboBox);
		}
	}
}
