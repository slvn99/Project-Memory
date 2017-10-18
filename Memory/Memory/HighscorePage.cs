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

            Controls.Add(Home);
            Home.BackColor = Color.Transparent;
        }

		private async void Home_Click(object sender, EventArgs e)
		{
			player.SoundLocation = "click.wav";
			player.Play();
			Memory.HomePage f2 = new Memory.HomePage();
			f2.Show();
			await Task.Delay(100);
			this.Close();
			this.ShowInTaskbar = false;
		}
	}
}
