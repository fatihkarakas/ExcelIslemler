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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label kurumAdiLabel;
            System.Windows.Forms.Label vknLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaneIsımler));
            this.hastaneIsmiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.kurumAdiTextBox = new System.Windows.Forms.TextBox();
            this.vknTextBox = new System.Windows.Forms.TextBox();
            this.hastaneIsmiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaneIsmiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankalarDataSet = new ExcelIslemler.BankalarDataSet();
            this.hastaneIsmiTableAdapter = new ExcelIslemler.BankalarDataSetTableAdapters.HastaneIsmiTableAdapter();
            this.tableAdapterManager = new ExcelIslemler.BankalarDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.hastaneIsmiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            kurumAdiLabel = new System.Windows.Forms.Label();
            vknLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneIsmiBindingNavigator)).BeginInit();
            this.hastaneIsmiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneIsmiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneIsmiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankalarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(11, 47);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 18);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // kurumAdiLabel
            // 
            kurumAdiLabel.AutoSize = true;
            kurumAdiLabel.Location = new System.Drawing.Point(131, 47);
            kurumAdiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kurumAdiLabel.Name = "kurumAdiLabel";
            kurumAdiLabel.Size = new System.Drawing.Size(80, 18);
            kurumAdiLabel.TabIndex = 3;
            kurumAdiLabel.Text = "Kurum Adi:";
            // 
            // vknLabel
            // 
            vknLabel.AutoSize = true;
            vknLabel.Location = new System.Drawing.Point(735, 49);
            vknLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vknLabel.Name = "vknLabel";
            vknLabel.Size = new System.Drawing.Size(37, 18);
            vknLabel.TabIndex = 5;
            vknLabel.Text = "Vkn:";
            // 
            // hastaneIsmiBindingNavigator
            // 
            this.hastaneIsmiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hastaneIsmiBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hastaneIsmiBindingNavigator.BindingSource = this.hastaneIsmiBindingSource;
            this.hastaneIsmiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hastaneIsmiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hastaneIsmiBindingNavigator.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.hastaneIsmiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hastaneIsmiBindingNavigatorSaveItem});
            this.hastaneIsmiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hastaneIsmiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hastaneIsmiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hastaneIsmiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hastaneIsmiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hastaneIsmiBindingNavigator.Name = "hastaneIsmiBindingNavigator";
            this.hastaneIsmiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hastaneIsmiBindingNavigator.Size = new System.Drawing.Size(1006, 26);
            this.hastaneIsmiBindingNavigator.TabIndex = 0;
            this.hastaneIsmiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 27);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hastaneIsmiBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(44, 47);
            this.idLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(133, 30);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            // 
            // kurumAdiTextBox
            // 
            this.kurumAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hastaneIsmiBindingSource, "KurumAdi", true));
            this.kurumAdiTextBox.Font = new System.Drawing.Font("Tahoma", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kurumAdiTextBox.Location = new System.Drawing.Point(219, 45);
            this.kurumAdiTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kurumAdiTextBox.Name = "kurumAdiTextBox";
            this.kurumAdiTextBox.Size = new System.Drawing.Size(511, 23);
            this.kurumAdiTextBox.TabIndex = 4;
            // 
            // vknTextBox
            // 
            this.vknTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hastaneIsmiBindingSource, "Vkn", true));
            this.vknTextBox.Location = new System.Drawing.Point(782, 44);
            this.vknTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vknTextBox.Name = "vknTextBox";
            this.vknTextBox.Size = new System.Drawing.Size(217, 24);
            this.vknTextBox.TabIndex = 6;
            // 
            // hastaneIsmiDataGridView
            // 
            this.hastaneIsmiDataGridView.AutoGenerateColumns = false;
            this.hastaneIsmiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hastaneIsmiDataGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.hastaneIsmiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastaneIsmiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.hastaneIsmiDataGridView.DataSource = this.hastaneIsmiBindingSource;
            this.hastaneIsmiDataGridView.Location = new System.Drawing.Point(14, 76);
            this.hastaneIsmiDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hastaneIsmiDataGridView.Name = "hastaneIsmiDataGridView";
            this.hastaneIsmiDataGridView.RowHeadersWidth = 49;
            this.hastaneIsmiDataGridView.Size = new System.Drawing.Size(985, 440);
            this.hastaneIsmiDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KurumAdi";
            this.dataGridViewTextBoxColumn2.HeaderText = "KurumAdi";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vkn";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vkn";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // hastaneIsmiBindingSource
            // 
            this.hastaneIsmiBindingSource.DataMember = "HastaneIsmi";
            this.hastaneIsmiBindingSource.DataSource = this.bankalarDataSet;
            // 
            // bankalarDataSet
            // 
            this.bankalarDataSet.DataSetName = "BankalarDataSet";
            this.bankalarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneIsmiTableAdapter
            // 
            this.hastaneIsmiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HastaneIsmiTableAdapter = this.hastaneIsmiTableAdapter;
            this.tableAdapterManager.UpdateOrder = ExcelIslemler.BankalarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 23);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 27);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 27);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 27);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 27);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 27);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // hastaneIsmiBindingNavigatorSaveItem
            // 
            this.hastaneIsmiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hastaneIsmiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hastaneIsmiBindingNavigatorSaveItem.Image")));
            this.hastaneIsmiBindingNavigatorSaveItem.Name = "hastaneIsmiBindingNavigatorSaveItem";
            this.hastaneIsmiBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 27);
            this.hastaneIsmiBindingNavigatorSaveItem.Text = "Save Data";
            this.hastaneIsmiBindingNavigatorSaveItem.Click += new System.EventHandler(this.hastaneIsmiBindingNavigatorSaveItem_Click);
            // 
            // HastaneIsımler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1006, 517);
            this.Controls.Add(this.hastaneIsmiDataGridView);
            this.Controls.Add(vknLabel);
            this.Controls.Add(this.vknTextBox);
            this.Controls.Add(kurumAdiLabel);
            this.Controls.Add(this.kurumAdiTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(this.hastaneIsmiBindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "HastaneIsımler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane İsim Bilgileri";
            this.Load += new System.EventHandler(this.HastaneIsımler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaneIsmiBindingNavigator)).EndInit();
            this.hastaneIsmiBindingNavigator.ResumeLayout(false);
            this.hastaneIsmiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneIsmiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneIsmiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankalarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankalarDataSet bankalarDataSet;
        private System.Windows.Forms.BindingSource hastaneIsmiBindingSource;
        private BankalarDataSetTableAdapters.HastaneIsmiTableAdapter hastaneIsmiTableAdapter;
        private BankalarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hastaneIsmiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hastaneIsmiBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox kurumAdiTextBox;
        private System.Windows.Forms.TextBox vknTextBox;
        private System.Windows.Forms.DataGridView hastaneIsmiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}