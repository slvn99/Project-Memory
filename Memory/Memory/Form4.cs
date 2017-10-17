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
    public partial class Form4 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();


        public Form4()
        {
            InitializeComponent();

            Loading_bar.Controls.Add(label1);
            label1.BackColor = Color.Transparent;

            timer1.Start();
            timer2.Start();
            timer3.Start();

            ChangeCursor();

            Random rand = new Random();
            double a = rand.Next(1, 7);

            if (a == 1)
            {
                label1.Text = "Randomizing cards";
				label1.Font = new Font("Arial", 18, FontStyle.Bold);
				label1.ForeColor = System.Drawing.Color.Black;
				label1.AutoSize = false;
				label1.TextAlign = ContentAlignment.MiddleCenter;
				label1.Dock = DockStyle.Fill;
			}


            else if (a == 2)
            {
				label1.Text = "Finishing the last preparations";
				label1.Font = new Font("Arial", 18, FontStyle.Bold);
				label1.ForeColor = System.Drawing.Color.Black;
				label1.AutoSize = false;
				label1.TextAlign = ContentAlignment.MiddleCenter;
				label1.Dock = DockStyle.Fill;
			}

            else if (a == 3)
            {
                label1.Text = "Showing an extremly useless loading screen";
				label1.Font = new Font("Arial", 18, FontStyle.Bold);
				label1.ForeColor = System.Drawing.Color.Black;
				label1.AutoSize = false;
				label1.TextAlign = ContentAlignment.MiddleCenter;
				label1.Dock = DockStyle.Fill;
			}

            else if (a == 4)
            {
                label1.Text = "Giving you some time to mentally prepare";
				label1.Font = new Font("Arial", 18, FontStyle.Bold);
				label1.ForeColor = System.Drawing.Color.Black;
				label1.AutoSize = false;
				label1.TextAlign = ContentAlignment.MiddleCenter;
				label1.Dock = DockStyle.Fill;
			}

            else if (a == 5)
            {
                label1.Text = "Wasting valuable time";
				label1.Font = new Font("Arial", 18, FontStyle.Bold);
				label1.ForeColor = System.Drawing.Color.Black;
				label1.AutoSize = false;
				label1.TextAlign = ContentAlignment.MiddleCenter;
				label1.Dock = DockStyle.Fill;
			}

            else if (a == 6)
            {
				label1.Text = "Testing players for hacks";
			    label1.Font = new Font("Arial", 18, FontStyle.Bold);
				label1.ForeColor = System.Drawing.Color.Black;
				label1.AutoSize = false;
				label1.TextAlign = ContentAlignment.MiddleCenter; 
				label1.Dock = DockStyle.Fill; 
			}
        }

        void ChangeCursor()
        {
            Bitmap bmp = new Bitmap(Properties.Resources.mouse_xs);
            Cursor c = new Cursor(bmp.GetHicon());
            this.Cursor = c;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WindowsFormsApp1.Form1  f1 = new WindowsFormsApp1.Form1();
            f1.Show();
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Memory.Form3 f6 = new Memory.Form3();
            f6.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            player.SoundLocation = "ping.wav";
            player.Play();
        }
    }
}
