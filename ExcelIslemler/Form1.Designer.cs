namespace ExcelIslemler
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExcelBtn = new System.Windows.Forms.Button();
            this.ExcelSonucView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaneİsimleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logKayıtlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelSonucView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExcelBtn.Location = new System.Drawing.Point(4, 40);
            this.ExcelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(171, 34);
            this.ExcelBtn.TabIndex = 0;
            this.ExcelBtn.Text = "Excel Dosyasını Seç";
            this.ExcelBtn.UseVisualStyleBackColor = true;
            this.ExcelBtn.Click += new System.EventHandler(this.ExcelBtn_Click);
            // 
            // ExcelSonucView
            // 
            this.ExcelSonucView.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.ExcelSonucView.AllowUserToAddRows = false;
            this.ExcelSonucView.AllowUserToDeleteRows = false;
            this.ExcelSonucView.AllowUserToOrderColumns = true;
            this.ExcelSonucView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExcelSonucView.BackgroundColor = System.Drawing.Color.Azure;
            this.ExcelSonucView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExcelSonucView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExcelSonucView.ColumnHeadersHeight = 28;
            this.ExcelSonucView.Location = new System.Drawing.Point(4, 78);
            this.ExcelSonucView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExcelSonucView.Name = "ExcelSonucView";
            this.ExcelSonucView.RowHeadersWidth = 35;
            this.ExcelSonucView.RowTemplate.Height = 24;
            this.ExcelSonucView.Size = new System.Drawing.Size(968, 423);
            this.ExcelSonucView.TabIndex = 1;
            this.ExcelSonucView.Visible = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(182, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "DTO İşlemi Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Excel DTO Oluştur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.FormattingEnabled = true;
            this.listView1.ItemHeight = 16;
            this.listView1.Location = new System.Drawing.Point(1, 505);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.ScrollAlwaysVisible = true;
            this.listView1.Size = new System.Drawing.Size(971, 148);
            this.listView1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.hastaneİsimleriToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.logKayıtlarıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            // 
            // hastaneİsimleriToolStripMenuItem
            // 
            this.hastaneİsimleriToolStripMenuItem.Name = "hastaneİsimleriToolStripMenuItem";
            this.hastaneİsimleriToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.hastaneİsimleriToolStripMenuItem.Text = "Hastane İsimleri";
            this.hastaneİsimleriToolStripMenuItem.Click += new System.EventHandler(this.hastaneİsimleriToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // logKayıtlarıToolStripMenuItem
            // 
            this.logKayıtlarıToolStripMenuItem.Name = "logKayıtlarıToolStripMenuItem";
            this.logKayıtlarıToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.logKayıtlarıToolStripMenuItem.Text = "Log Kayıtları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(982, 659);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExcelSonucView);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DTO Dosyası Oluştur";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExcelSonucView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExcelBtn;
        private System.Windows.Forms.DataGridView ExcelSonucView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaneİsimleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logKayıtlarıToolStripMenuItem;
        public System.Windows.Forms.ListBox listView1;
    }
}

