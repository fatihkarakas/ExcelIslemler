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
    public partial class HastaneIsımler : Form
    {
        dtoContext dto = new dtoContext();
        public HastaneIsımler()
        {
            InitializeComponent();
        }

      

        private void HastaneIsımler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankalarDataSet.HastaneIsmi' table. You can move, or remove it, as needed.
          
            hastanelerGridView.DataSource = dto.HastaneBilgi.OrderBy(o=> o.KurumAdi).ToList();
            hastanelerGridView.Columns[0].Width = 50;
            hastanelerGridView.Columns[1].Width = 800;
            hastanelerGridView.Columns[2].Width = 100;
            label3.Text = $"Toplam {hastanelerGridView.RowCount} kadar hastane kaydı bulundu";

        }

        private void hastanelerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
            DataGridViewRow row = hastanelerGridView.Rows[e.RowIndex];
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            }
           
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastanelerGridView.DataSource = dto.HastaneBilgi
                .Where(x=> x.Vkn.Contains(textBox2.Text))
                .Where(x=> x.KurumAdi.Contains(textBox1.Text))
                .OrderBy(o => o.KurumAdi).ToList();
            hastanelerGridView.Columns[0].Width = 50;
            hastanelerGridView.Columns[1].Width = 800;
            hastanelerGridView.Columns[2].Width = 100;
            label3.Text = $"Toplam {hastanelerGridView.RowCount} adet hastane kaydı bulundu";
        }
    }
}
