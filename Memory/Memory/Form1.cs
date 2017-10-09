using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button[] ButtonGrid = {GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };

            foreach (var x in ButtonGrid)
            {
                x.Visible = false;
            }






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            Play_Game();
        }

        private void Play_Game()
        {
            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup};
            foreach (var x in ButtonGrid)
            {
                x.Visible = true;
                PlayButton.Visible = false;
            }

            foreach (Button Button in ButtonGrid)
            {
                Button.Text = "[=]";
            }

        }
        #region kaarten
        private void GridButton1_Click(object sender, EventArgs e)
        {
            GridButton1.Text = "A";
        }

        private void GridButton1Dup_Click(object sender, EventArgs e)
        {
            GridButton1Dup.Text = "A";
        }

        private void GridButton2_Click(object sender, EventArgs e)
        {
            GridButton2.Text = "B";
        }

        private void GridButton2Dub_Click(object sender, EventArgs e)
        {
            GridButton2Dup.Text = "B";
        }

        private void GridButton3_Click(object sender, EventArgs e)
        {
            GridButton3.Text = "C";
        }

        private void GridButton3Dub_Click(object sender, EventArgs e)
        {
            GridButton3Dup.Text = "C";
        }

        private void GridButton4_Click(object sender, EventArgs e)
        {
            GridButton4.Text = "D";
        }

        private void GridButton4Dub_Click(object sender, EventArgs e)
        {
            GridButton4Dup.Text = "D";
        }

        private void GridButton5_Click(object sender, EventArgs e)
        {
            GridButton5.Text = "E";
        }

        private void GridButton5Dub_Click(object sender, EventArgs e)
        {
            GridButton5Dup.Text = "E";
        }

        private void GridButton6_Click(object sender, EventArgs e)
        {
            GridButton6.Text = "F";
        }

        private void GridButton6Dub_Click(object sender, EventArgs e)
        {
            GridButton6Dup.Text = "F";
        }

        private void GridButton7_Click(object sender, EventArgs e)
        {
            GridButton7.Text = "G";
        }

        private void GridButton7Dup_Click(object sender, EventArgs e)
        {
            GridButton7Dup.Text = "G";
        }

        private void GridButton8_Click(object sender, EventArgs e)
        {
            GridButton8.Text = "H";
        }

        private void GridButton8Dup_Click(object sender, EventArgs e)
        {
            GridButton8Dup.Text = "H";
        }
        #endregion
    }
}
