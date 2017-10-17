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
        public HighscorePage()
        {
            InitializeComponent();
            string save = Highscores_save.LoadData();
            if (save == "Er is nog geen\nsave file\naanwezig")
            { }
            else
            {
                //save string wordt gesplit op \n en in string array gezet
                string[] savearray = save.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                //toekennen van waarden uit array aan variabelen
                label1.Text = savearray[1];
                label2.Text = savearray[2];
                label3.Text = savearray[3];
                label4.Text = savearray[4];
                label5.Text = savearray[5];
                label6.Text = savearray[6];
                label7.Text = savearray[7];
                label8.Text = savearray[8];
                label9.Text = savearray[9];
                label10.Text = savearray[10];

            }
        }
    }
}
