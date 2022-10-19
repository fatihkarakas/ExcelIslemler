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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaneIsımler));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label kurumAdiLabel;
            System.Windows.Forms.Label vknLabel;
            this.hastaneIsmiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.hastaneIsmiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            // hastaneIsmiBindingNavigator
            // 
            this.hastaneIsmiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hastaneIsmiBindingNavigator.BindingSource = this.hastaneIsmiBindingSource;
            this.hastaneIsmiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hastaneIsmiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.hastaneIsmiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.hastaneIsmiBindingNavigator.TabIndex = 0;
            this.hastaneIsmiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // hastaneIsmiBindingNavigatorSaveItem
            // 
            this.hastaneIsmiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hastaneIsmiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hastaneIsmiBindingNavigatorSaveItem.Image")));
            this.hastaneIsmiBindingNavigatorSaveItem.Name = "hastaneIsmiBindingNavigatorSaveItem";
            this.hastaneIsmiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hastaneIsmiBindingNavigatorSaveItem.Text = "Save Data";
            this.hastaneIsmiBindingNavigatorSaveItem.Click += new System.EventHandler(this.hastaneIsmiBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(8, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hastaneIsmiBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(33, 36);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            // 
            // kurumAdiLabel
            // 
            kurumAdiLabel.AutoSize = true;
            kurumAdiLabel.Location = new System.Drawing.Point(168, 38);
            kurumAdiLabel.Name = "kurumAdiLabel";
            kurumAdiLabel.Size = new System.Drawing.Size(58, 13);
            kurumAdiLabel.TabIndex = 3;
            kurumAdiLabel.Text = "Kurum Adi:";
            // 
            // kurumAdiTextBox
            // 
            this.kurumAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hastaneIsmiBindingSource, "KurumAdi", true));
            this.kurumAdiTextBox.Location = new System.Drawing.Point(232, 34);
            this.kurumAdiTextBox.Name = "kurumAdiTextBox";
            this.kurumAdiTextBox.Size = new System.Drawing.Size(317, 20);
            this.kurumAdiTextBox.TabIndex = 4;
            // 
            // vknLabel
            // 
            vknLabel.AutoSize = true;
            vknLabel.Location = new System.Drawing.Point(555, 37);
            vknLabel.Name = "vknLabel";
            vknLabel.Size = new System.Drawing.Size(29, 13);
            vknLabel.TabIndex = 5;
            vknLabel.Text = "Vkn:";
            // 
            // vknTextBox
            // 
            this.vknTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hastaneIsmiBindingSource, "Vkn", true));
            this.vknTextBox.Location = new System.Drawing.Point(590, 33);
            this.vknTextBox.Name = "vknTextBox";
            this.vknTextBox.Size = new System.Drawing.Size(198, 20);
            this.vknTextBox.TabIndex = 6;
            // 
            // hastaneIsmiDataGridView
            // 
            this.hastaneIsmiDataGridView.AutoGenerateColumns = false;
            this.hastaneIsmiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hastaneIsmiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastaneIsmiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.hastaneIsmiDataGridView.DataSource = this.hastaneIsmiBindingSource;
            this.hastaneIsmiDataGridView.Location = new System.Drawing.Point(12, 101);
            this.hastaneIsmiDataGridView.Name = "hastaneIsmiDataGridView";
            this.hastaneIsmiDataGridView.Size = new System.Drawing.Size(788, 335);
            this.hastaneIsmiDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KurumAdi";
            this.dataGridViewTextBoxColumn2.HeaderText = "KurumAdi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vkn";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vkn";
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
            // HastaneIsımler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.hastaneIsmiDataGridView);
            this.Controls.Add(vknLabel);
            this.Controls.Add(this.vknTextBox);
            this.Controls.Add(kurumAdiLabel);
            this.Controls.Add(this.kurumAdiTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(this.hastaneIsmiBindingNavigator);
            this.Name = "HastaneIsımler";
            this.Text = "HastaneIsımler";
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