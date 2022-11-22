using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        dtoContext DtoContext;
        public string test = ConfigurationManager.ConnectionStrings["ExcelIslemler.Properties.Settings.BankalarConnectionString"].ConnectionString;
        public string Baglanti = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Bankalar.mdf;Integrated Security=True";
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
                        ErtoHata erto = new ErtoHata();
                        erto.hatBaslik = $"Layynn Bir Bak Hata Oluştu";
                        erto.hatMesaj = $"Ağzını kırdığım seçtğin dosya excel mi bir bak bakalım: {dlg.FileName}  dosyasını seçtün";
                        erto.Show();

                        //  MessageBox.Show($"Ağzını kırdığım seçtğin dosya excel mi bir bak bakalım :  {dlg.FileName} dosyasını seçtün", "Layynn Bir Bak Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
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



        private void button1_Click(object sender, EventArgs e)
        {
            DtoContext = new dtoContext();
            System.Data.DataTable ds = new System.Data.DataTable();
            var kactane = ExcelSonucView.ColumnCount;
            var satir = ExcelSonucView.RowCount;
            int sat = 0;
            DataSet Ds = new DataSet();
            SqlDataAdapter DT = new SqlDataAdapter();
            List<HastaneBilgi> KurumAdlari = DtoContext.HastaneBilgi.
                Where(x=> x.IsActive==1)
                .ToList();
           

            List<VeriKontrol> veri = new List<VeriKontrol>();
            foreach (DataGridViewRow item in ExcelSonucView.Rows)
            {

                sat++;
                if (sat <= satir)
                {
                    try
                    {
                        VeriKontrol hastane = new VeriKontrol();
                        hastane.Banka = Convert.ToString(item.Cells[4].Value);
                        hastane.VegiKimlikNo = Convert.ToString(item.Cells[3].Value);
                        int s = KurumAdlari.Where(x => x.Vkn.Contains(hastane.VegiKimlikNo)).ToList().Count;
                        if (s >0 && hastane.VegiKimlikNo !="")
                        {
                           
                            if (s > 1)
                            {
                                hastane.extra += $" {hastane.VegiKimlikNo} vergi kimlik numarası {s} tekrar edilmiş.";
                                listView1.Items.Add($" {hastane.VegiKimlikNo} vergi kimlik numarası {s} tekrar edilmiş.");
                            }
                            else
                            {
                                hastane.extra += "OK";
                            }
                            hastane.KurumAdi = KurumAdlari.FirstOrDefault(x => x.Vkn.Contains(hastane.VegiKimlikNo)).KurumAdi;
                            listView1.Items.Add($"{Convert.ToString(item.Cells[2].Value)} hastane adı {hastane.KurumAdi} olarak değiştirildi.." );
                        }
                        else
                        {
                            hastane.KurumAdi = Convert.ToString(item.Cells[2].Value);
                            listView1.Items.Add($"{hastane.KurumAdi} için kullanılan bu {hastane.VegiKimlikNo} bankada kayıtlı değil");
                            hastane.extra = $"{hastane.KurumAdi} için kullanılan bu {hastane.VegiKimlikNo} bankada kayıtlı değil";
                            //MessageBox.Show($"{hastane.KurumAdi} için kullanılan bu {hastane.VegiKimlikNo} bankada kayıtlı değil");
                        }
                        hastane.Kisi = Convert.ToString(item.Cells[1].Value);
                        hastane.Iban = Convert.ToString(item.Cells[5].Value);
                       
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
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Seçtiğiniz Excel Dosyası DTO çevirme formatına uygun değil \n{ex.Message}", "Dosya İşlemede hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }


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
            string HangiHast = Prompt.ShowDialog("Hangi hastane için işlem yapılacak :", "Hastane Seçiniz");
            string OdemeTur = Prompt.ShowDialog("Ödeme Türünü yazınız :", "Ödeme Seçiniz");
            string HangiAy = Prompt.ShowDialog("Ödeme Ayı:", "Ödeme Ayı Seçiniz");
            if (HangiAy == ""|| HangiAy == null) HangiAy = date.ToString("MMMM");

            foreach (var item in veri)
            {
                DTO dt = new DTO();
                dt.banka = item.Banka;
                dt.ilgili = item.KurumAdi;
                dt.vkn = item.VegiKimlikNo;
                dt.aciklama = item.Kactane == 1 ? $"{HangiHast} {OdemeTur} {HangiAy} / {DateTime.Now.Year}   {item.Kisi.ToUpper()} " : $"{HangiHast} {OdemeTur}{HangiAy} / {DateTime.Now.Year}  {item.Kactane} KİŞİ";
                dt.miktar = item.OdemeTutar;
                dt.fisNo = "";
                dt.hesapNo = item.Iban;
                dt.extralar = item.extra;
                dTOs.Add(dt);
            }
            var ToplmPara = dTOs.Sum(a => a.miktar);
            listView1.Items.Add($"Bu DTO dosyasında ödenecek toplam miktar {ToplmPara} TL dir");
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

                        if (sf.ShowDialog() == DialogResult.OK)
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dt, "Dto Listesi");
                                wb.SaveAs(sf.FileName);
                                var Klasör = Path.GetFullPath(sf.FileName);
                                //MessageBox.Show($"DTO excel dosyanız {folderPath} klasörüne Dtos{DateTime.Now.ToShortDateString()}.xlsx adıyla kayıt edildi", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show($"DTO excel dosyanız {Klasör}  adresine kayıt edildi", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listView1.Items.Add($"DTO excel dosyanız {Klasör}  adresine kayıt edildi");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkinda h = new Hakkinda();
            h.Show();
        }

        private void hastaneİsimleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaneIsımler h = new HastaneIsımler();
            h.Show();
        }
    }
}