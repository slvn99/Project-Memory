using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Deze vorm fungeert als form die een intro video afspeelt, waarin te zien is dat onze groep verantwoordelijk is voor dit memory spel.
namespace Memory
{
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();

            Cursor.Hide();

            timer1.Start();
        }
        public void Sluiten()
        {
            Cursor.Show();
            Memory.HomePage  H1 = new Memory.HomePage();
            H1.Show();
            this.Close();
            Dispose();
            GC.Collect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Sluiten();
        }
    }
}
