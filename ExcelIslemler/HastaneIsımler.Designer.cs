namespace ExcelIslemler
{
    partial class HastaneIsımler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaneIsımler));
            this.hastanelerGridView = new System.Windows.Forms.DataGridView();
            this.TextKurumAdi = new System.Windows.Forms.TextBox();
            this.textVKN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EkleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hastanelerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hastanelerGridView
            // 
            this.hastanelerGridView.AllowDrop = true;
            this.hastanelerGridView.AllowUserToOrderColumns = true;
            this.hastanelerGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hastanelerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hastanelerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastanelerGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hastanelerGridView.Location = new System.Drawing.Point(1, 42);
            this.hastanelerGridView.Name = "hastanelerGridView";
            this.hastanelerGridView.RowHeadersWidth = 49;
            this.hastanelerGridView.RowTemplate.Height = 24;
            this.hastanelerGridView.Size = new System.Drawing.Size(1022, 418);
            this.hastanelerGridView.TabIndex = 0;
            this.hastanelerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hastanelerGridView_CellClick);
            this.hastanelerGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.hastanelerGridView_CellEndEdit);
            this.hastanelerGridView.DoubleClick += new System.EventHandler(this.hastanelerGridView_DoubleClick);
            // 
            // TextKurumAdi
            // 
            this.TextKurumAdi.Location = new System.Drawing.Point(96, 12);
            this.TextKurumAdi.Name = "TextKurumAdi";
            this.TextKurumAdi.Size = new System.Drawing.Size(547, 22);
            this.TextKurumAdi.TabIndex = 1;
            // 
            // textVKN
            // 
            this.textVKN.Location = new System.Drawing.Point(685, 12);
            this.textVKN.Name = "textVKN";
            this.textVKN.Size = new System.Drawing.Size(218, 22);
            this.textVKN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "VKN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "HASTANE ADI :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(909, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 4;
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(961, 11);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(46, 23);
            this.EkleBtn.TabIndex = 3;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // HastaneIsımler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1027, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textVKN);
            this.Controls.Add(this.TextKurumAdi);
            this.Controls.Add(this.hastanelerGridView);
            this.Font = new System.Drawing.Font("Tahoma", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HastaneIsımler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane İsim Bilgileri";
            this.Load += new System.EventHandler(this.HastaneIsımler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastanelerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hastanelerGridView;
        private System.Windows.Forms.TextBox TextKurumAdi;
        private System.Windows.Forms.TextBox textVKN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EkleBtn;
    }
}