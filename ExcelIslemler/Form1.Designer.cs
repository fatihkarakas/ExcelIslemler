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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExcelBtn = new System.Windows.Forms.Button();
            this.ExcelSonucView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExcelSonucView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Location = new System.Drawing.Point(33, 12);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(170, 35);
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
            this.ExcelSonucView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.ExcelSonucView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.ExcelSonucView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExcelSonucView.Location = new System.Drawing.Point(2, 53);
            this.ExcelSonucView.Name = "ExcelSonucView";
            this.ExcelSonucView.RowHeadersWidth = 35;
            this.ExcelSonucView.RowTemplate.Height = 24;
            this.ExcelSonucView.Size = new System.Drawing.Size(968, 412);
            this.ExcelSonucView.TabIndex = 1;
            this.ExcelSonucView.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "DTO İşlemi Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 29);
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
            this.listView1.Location = new System.Drawing.Point(2, 472);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(968, 84);
            this.listView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 605);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExcelSonucView);
            this.Controls.Add(this.ExcelBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DTO Dosyası Oluştur";
            ((System.ComponentModel.ISupportInitialize)(this.ExcelSonucView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExcelBtn;
        private System.Windows.Forms.DataGridView ExcelSonucView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listView1;
    }
}

