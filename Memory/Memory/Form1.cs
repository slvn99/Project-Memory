﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Memory;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Button Kaart1Select, Kaart2Select;

        public Form1()
        {
            InitializeComponent();
            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };

            foreach (var x in ButtonGrid)
            {
                x.Visible = false;
            }

            foreach (Button Button in ButtonGrid)
            {
                Button.Text = "[=]";
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
            Button[] ButtonGrid = { GridButton1, GridButton1Dup, GridButton2, GridButton2Dup, GridButton3, GridButton3Dup, GridButton4, GridButton4Dup, GridButton5, GridButton5Dup, GridButton6, GridButton6Dup, GridButton7, GridButton7Dup, GridButton8, GridButton8Dup };
            foreach (var x in ButtonGrid)
            {
                x.Visible = true;
                PlayButton.Visible = false;
            }

            Player1Label.Visible = false;
            Player1Textbox.Visible = false;
            Player2Label.Visible = false;
            Player2Textbox.Visible = false;
            Player1LabelInvoer.Visible = true;
            Player1LabelInvoer.Visible = true;



            Player1LabelInvoer.Text = "Speler 1: " + Player1Textbox.Text;
            Player2LabelInvoer.Text = "Speler 2: " + Player2Textbox.Text;

            string player1 = Player1LabelInvoer.Text;
            string player2 = Player2LabelInvoer.Text;
        }

        private void Click_kaart(Button Buttonclick)
        {
            if (Kaart1Select == null)
            {
                Kaart1Select = Buttonclick;
            }
            else if (Kaart1Select != null && Kaart2Select == null)
            {
                Kaart2Select = Buttonclick;
            }
        }

        private async void Check_kaart()
        {
            if (Kaart1Select != null && Kaart2Select != null)
            {
                if (Kaart1Select.Tag == Kaart2Select.Tag)
                {
                    MessageBox.Show("match");
                    Kaart1Select = null;
                    Kaart2Select = null;
                }
                else
                {
                    await Task.Delay(3000);
                    Kaart1Select.Text = "[=]";
                    Kaart2Select.Text = "[=]";
                    Kaart1Select = null;
                    Kaart2Select = null;
                }
            }
        }

        private void GridButton1_Click(object sender, EventArgs e)
        {
            GridButton1.Text = "A";
            Click_kaart(GridButton1);
            Check_kaart();
        }

        private void GridButton1Dup_Click(object sender, EventArgs e)
        {
            GridButton1Dup.Text = "A";
            Click_kaart(GridButton1Dup);
            Check_kaart();
        }

        private void GridButton2_Click(object sender, EventArgs e)
        {
            GridButton2.Text = "B";
            Click_kaart(GridButton2);
            Check_kaart();
        }

        private void GridButton2Dub_Click(object sender, EventArgs e)
        {
            GridButton2Dup.Text = "B";
            Click_kaart(GridButton2Dup);
            Check_kaart();
        }

        private void GridButton3_Click(object sender, EventArgs e)
        {
            GridButton3.Text = "C";
            Click_kaart(GridButton3);
            Check_kaart();
        }

        private void GridButton3Dub_Click(object sender, EventArgs e)
        {
            GridButton3Dup.Text = "C";
            Click_kaart(GridButton3Dup);
            Check_kaart();
        }

        private void GridButton4_Click(object sender, EventArgs e)
        {
            GridButton4.Text = "D";
            Click_kaart(GridButton4);
            Check_kaart();
        }

        private void GridButton4Dub_Click(object sender, EventArgs e)
        {
            GridButton4Dup.Text = "D";
            Click_kaart(GridButton4Dup);
            Check_kaart();
        }

        private void GridButton5_Click(object sender, EventArgs e)
        {
            GridButton5.Text = "E";
            Click_kaart(GridButton5);
            Check_kaart();
        }

        private void GridButton5Dub_Click(object sender, EventArgs e)
        {
            GridButton5Dup.Text = "E";
            Click_kaart(GridButton5Dup);
            Check_kaart();
        }

        private void GridButton6_Click(object sender, EventArgs e)
        {
            GridButton6.Text = "F";
            Click_kaart(GridButton6);
            Check_kaart();
        }

        private void GridButton6Dub_Click(object sender, EventArgs e)
        {
            GridButton6Dup.Text = "F";
            Click_kaart(GridButton6Dup);
            Check_kaart();
        }

        private void GridButton7_Click(object sender, EventArgs e)
        {
            GridButton7.Text = "G";
            Click_kaart(GridButton7);
            Check_kaart();
        }

        private void GridButton7Dup_Click(object sender, EventArgs e)
        {
            GridButton7Dup.Text = "G";
            Click_kaart(GridButton7Dup);
            Check_kaart();
        }

        private void GridButton8_Click(object sender, EventArgs e)
        {
            GridButton8.Text = "H";
            Click_kaart(GridButton8);
            Check_kaart();
        }

        private void GridButton8Dup_Click(object sender, EventArgs e)
        {
            GridButton8Dup.Text = "H";
            Click_kaart(GridButton8Dup);
            Check_kaart();
        }

        public void Saveclass_Click(object sender, EventArgs e)
        {
            value.Text =  Save.SaveData();
        }   
    }
}
