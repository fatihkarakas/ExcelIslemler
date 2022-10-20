using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelIslemler
{
    
    public partial class ErtoHata : Form
    {
        public string hatMesaj { get; set; }
        public string hatBaslik { get; set; }
        public SoundPlayer ses = new SoundPlayer($"{Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)}\\Image\\mp3indirdur-Orhan-Gencebay-Hatasiz-Kul-Olmaz.wav");
        public ErtoHata()
        {
            InitializeComponent();
           
        }

        private void ErtoHata_Load(object sender, EventArgs e)
        {
           
            
            ses.Play();
            label1.Text = hatMesaj;
            label2.Text = hatBaslik;
        }

        private void ErtoHata_FormClosed(object sender, FormClosedEventArgs e)
        {
                ses.Stop();
        }
    }
}
