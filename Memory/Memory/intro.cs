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
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();

            timer1.Start();
        }
        public void Sluiten()
        {
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
