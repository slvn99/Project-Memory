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

            Button[] ButtonGrid = {GridButton1, GridButton2, GridButton3, GridButton4, GridButton5, GridButton6, GridButton7, GridButton8, GridButton9, GridButton10, GridButton11, GridButton12};

            foreach (var x in ButtonGrid)
            {
                x.Visible = false;
            }






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void PlayButton_Click(object sender, EventArgs e)
        {
            Button[] ButtonGrid = { GridButton1, GridButton2, GridButton3, GridButton4, GridButton5, GridButton6, GridButton7, GridButton8, GridButton9, GridButton10, GridButton11, GridButton12 };
            foreach (var x in ButtonGrid)
            {
                x.Visible = true;
                PlayButton.Visible = false;
            }
        }
    }
}
