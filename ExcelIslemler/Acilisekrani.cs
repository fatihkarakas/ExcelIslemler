using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelIslemler
{
    public partial class Acilisekrani : Form
    {
        private int i = 1;
        public Acilisekrani()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 30;
            

            i++;
            if (i % 2 == 0)
            {
                label1.ForeColor = Color.DarkBlue;
            }
            else
            {
                label1.ForeColor = Color.White;
            }
            if (panel2.Width >= 500)
            {
                timer1.Stop();
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
