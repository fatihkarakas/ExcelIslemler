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
        public ErtoHata()
        {
            InitializeComponent();
           
        }

        private void ErtoHata_Load(object sender, EventArgs e)
        {
            var test = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            SoundPlayer ses = new SoundPlayer($"{test}\\mp3indirdur-Orhan-Gencebay-Hatasiz-Kul-Olmaz.wav");
            ses.Play();
            label1.Text = hatMesaj;
            label2.Text = hatBaslik;
        }
    }
}
