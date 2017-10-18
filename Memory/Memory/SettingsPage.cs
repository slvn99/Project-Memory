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
		System.Media.SoundPlayer player = new System.Media.SoundPlayer();
		public SettingsPage()
		{
			InitializeComponent();
		}

		private void ThemaBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ThemaBox.SelectedItem == "Thema 1" )
			{
				
			}

			if (ThemaBox.SelectedItem == "Thema 2")
			{

			}

			if (ThemaBox.SelectedItem == "Thema 3")
			{

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
			Memory.Form2 f2 = new Memory.Form2();
			f2.Show();
			await Task.Delay(100);
			this.Close();
			this.ShowInTaskbar = false;
		}
	}
}
