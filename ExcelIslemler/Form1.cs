using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelIslemler
{
    public partial class Form1 : Form
    {
        public string fisAciklama;
        public Form1()
        {


            InitializeComponent();
        }

        private void ExcelBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Excel Ekleme seçildi \n");
            System.Data.DataTable dt = new System.Data.DataTable();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string ExcelAdres = Path.GetExtension(dlg.FileName);
                    if (ExcelAdres.CompareTo(".xls") == 0 || ExcelAdres.CompareTo(".xlsx") == 0)
                    {

                        using (XLWorkbook wb = new XLWorkbook(dlg.FileName))
                        {
                            listView1.Items.Add($"{dlg.FileName} dosyası seçildi \n");
                            bool IlkSatir = true;
                            var rows = wb.Worksheet(1).RowsUsed();
                            foreach (var row in rows)
                            {
                                if (IlkSatir)
                                {
                                    foreach (IXLCell cell in row.Cells())
                                    {
                                        dt.Columns.Add(cell.Value.ToString());
                                        IlkSatir = false;
                                    }
                                }
                                else
                                {
                                    dt.Rows.Add();
                                    int i = 0;
                                    foreach (IXLCell cell in row.Cells())
                                    {
                                        dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                                    }
                                }
                            }
                            ExcelSonucView.DataSource = dt;
                        }
                        //System.Data.DataTable dtExcel = ReadExcel(dlg.FileName); //excel okumaya başla
                        ExcelSonucView.Visible = true;
                      


                    }
                    else
                    {
                        MessageBox.Show("Lütfen excel dosyası seçimi yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    Cursor.Current = Cursors.Default;
                    button1.Visible = true;
                }
            }
            catch (Exception ex)
            {
                button1.Visible = false;
                MessageBox.Show($"Hata oluştu hata kodu {ex.Message.ToString()}", "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listView1.Items.Add($"{ex.Message.ToString()} hatası ouştu");
            }


        }

        //private System.Data.DataTable   ReadExcel(string ExcelAdres)
        //{


        //   //WorkBook  workBook = WorkBook.Load(ExcelAdres);

        //   // string sayfaAdi = workBook.DefaultWorkSheet.ToString();
        //   // WorkSheet worksheet = workBook.DefaultWorkSheet;
        //    return DataTable;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.DataTable ds = new System.Data.DataTable();
            var kactane = ExcelSonucView.ColumnCount;
            var satir = ExcelSonucView.RowCount;
            int sat = 0;
            List<VeriKontrol> veri = new List<VeriKontrol>();
            foreach (DataGridViewRow item in ExcelSonucView.Rows)
            {
                sat++;
                if (sat < satir)
                {
                    VeriKontrol hastane = new VeriKontrol();
                    hastane.KurumAdi = Convert.ToString(item.Cells[2].Value);
                    hastane.Kisi = Convert.ToString(item.Cells[1].Value);
                    hastane.Iban = Convert.ToString(item.Cells[5].Value);
                    hastane.VegiKimlikNo = Convert.ToString(item.Cells[3].Value);
                    //MessageBox.Show(item.Cells[6].Value.ToString());
                    hastane.OdemeTutar = Convert.ToDouble(item.Cells[6].Value);
                    if (veri.Contains(veri.Find(a => a.KurumAdi == hastane.KurumAdi)))
                    {
                        //MessageBox.Show($"{hastane.KurumAdi} kaydı vardır");
                        listView1.Items.Add($"{hastane.KurumAdi} kaydı tekrarlandı");
                        var hst = veri.FirstOrDefault(a => a.KurumAdi == hastane.KurumAdi);
                        hst.OdemeTutar += hastane.OdemeTutar;
                        hst.Kactane++;

                    }
                    else
                    {
                        veri.Add(hastane);
                    }
                }


                //  MessageBox.Show(hastane.KurumAdi);


            }
            var sonuc = veri;
            var sifirolanliste = veri.FindAll(a => a.OdemeTutar == 0);
            var kayitlist = veri.RemoveAll(a => a.OdemeTutar == 0);
            MessageBox.Show($"Ödeme tutarı 0 olan {kayitlist} kayıt silindi ");
            listView1.Items.Add($"Ödeme tutarı 0 olan {kayitlist} kayıt silindi");
            foreach (var item in sifirolanliste)
            {
                listView1.Items.Add($"Ödeme tutarı 0 olan {item.KurumAdi} na ait kayıt silindi");
            }

            ExcelSonucView.DataSource = veri;
            List<DTO> dTOs = new List<DTO>();
            DateTime date = DateTime.Now;
            foreach (var item in veri)
            {
                DTO dt = new DTO();
                dt.ilgili = item.KurumAdi;
                dt.vkn = item.VegiKimlikNo;
                dt.aciklama = item.Kactane == 1 ? $"ANKARA ŞEHİR HST. TEMEL EK ÖDEME {DateTime.Now.Year} : {date.ToString("MMMM")} {item.Kisi.ToUpper()} " : $"ANKARA ŞEHİR HST. TEMEL EK ÖDEME {DateTime.Now.Year} : {date.ToString("MMMM")} {item.Kactane} KİŞİ";
                dt.miktar = item.OdemeTutar;
                dt.fisNo = "";
                dt.hesapNo = item.Iban;
                dTOs.Add(dt);
            }
            ExcelSonucView.DataSource = dTOs;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ExcelSonucView.Rows.Count > 1)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in ExcelSonucView.Columns)
                {
                    dt.Columns.Add(column.HeaderText, column.ValueType);
                }

                //Adding the Rows
                foreach (DataGridViewRow row in ExcelSonucView.Rows)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }
                try
                {
                    using (SaveFileDialog sf = new SaveFileDialog() { Filter = "Excel Sayfası |*.xlsx" })
                    {
                        //string folderPath = "C:\\Excel\\";
                        //if (!Directory.Exists(folderPath))
                        //{
                        //    Directory.CreateDirectory(folderPath);
                        //}
                        if(sf.ShowDialog() == DialogResult.OK)
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dt, "Dto Listesi");
                                wb.SaveAs(sf.FileName);
                                //MessageBox.Show($"DTO excel dosyanız {folderPath} klasörüne Dtos{DateTime.Now.ToShortDateString()}.xlsx adıyla kayıt edildi", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show($"DTO excel dosyanız {Path.GetFileName(sf.FileName)} klasörüne Dtos{sf.FileName} adıyla kayıt edildi", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                       
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu hata kodu {ex.Message.ToString()}", "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }
    }
}