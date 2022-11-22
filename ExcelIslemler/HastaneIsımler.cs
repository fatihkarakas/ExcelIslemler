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
            hastanelerGridView.Columns[0].Width = 40;
            hastanelerGridView.Columns[1].Width = 750;
            hastanelerGridView.Columns[2].Width = 100;
            hastanelerGridView.Columns[3].Width = 50;
            label3.Text = $"Toplam {hastanelerGridView.RowCount} kadar hastane kaydı bulundu";
            Renkledir();
            
          
        }

        public void Renkledir()
        {
            foreach (DataGridViewRow r in hastanelerGridView.Rows)
            {
                if (r.Cells[3].Value.ToString() == "1")
                {
                    r.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    r.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

       

        private void hastanelerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
            DataGridViewRow row = hastanelerGridView.Rows[e.RowIndex];
            TextKurumAdi.Text = row.Cells[1].Value.ToString();
            textVKN.Text = row.Cells[2].Value.ToString();
            }
           
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Vkn = textVKN.Text;
            var KurumAdi = TextKurumAdi.Text;
            hastanelerGridView.DataSource = dto.HastaneBilgi
                .Where(x=> x.Vkn.Contains(Vkn))
                .Where(x=> x.KurumAdi.Contains(KurumAdi))
                .OrderBy(o => o.KurumAdi).ToList();
            hastanelerGridView.Columns[0].Width = 40;
            hastanelerGridView.Columns[1].Width = 750;
            hastanelerGridView.Columns[2].Width = 100;
            hastanelerGridView.Columns[3].Width = 50;
            label3.Text = $"Toplam {hastanelerGridView.RowCount} adet hastane kaydı bulundu";
        }

        private void hastanelerGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var et = (int) hastanelerGridView.CurrentRow.Cells[0].Value;
            try
            {
                HastaneBilgi h = dto.HastaneBilgi.Where(x => x.Id == et).FirstOrDefault();
                h.KurumAdi = hastanelerGridView.CurrentRow.Cells[1].Value.ToString();
                h.Vkn = hastanelerGridView.CurrentRow.Cells[2].Value.ToString();
                dto.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu : {ex.Message.ToString()}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
            MessageBox.Show("Güncelleme işlemi tamamlandı","İşlem TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hastanelerGridView_DoubleClick(object sender, EventArgs e)
        {
            var et = (int)hastanelerGridView.CurrentRow.Cells[0].Value;
            var sn = (byte)hastanelerGridView.CurrentRow.Cells[3].Value;
            try
            {
                HastaneBilgi h = dto.HastaneBilgi.Where(x => x.Id == et).FirstOrDefault();
                h.IsActive = (byte)(sn == 1 ? 0 : 1);
                dto.SaveChanges();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu : {ex.Message.ToString()}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Renkledir();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                HastaneBilgi h = new HastaneBilgi()
                {
                    KurumAdi = TextKurumAdi.Text,
                    Vkn = textVKN.Text,

                };
               int say = dto.HastaneBilgi.Where(x=> x.Vkn.Contains(h.Vkn) || x.KurumAdi.Contains(h.KurumAdi)).Count();
                if (say == 0)
                {
                    dto.HastaneBilgi.Add(h);
                    dto.SaveChanges();
                    MessageBox.Show($"İşlem Tamamlandı", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hastanelerGridView.DataSource = dto.HastaneBilgi.OrderBy(o => o.KurumAdi).ToList();
                }
                else if(say >0)
                {
                    MessageBox.Show($"Hata oluştu : {h.KurumAdi} hastane adı veya {h.Vkn} Vkn numrası zaten kayıtlı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu : {ex.Message.ToString()}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
