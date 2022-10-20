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
        public HastaneIsımler()
        {
            InitializeComponent();
        }

        private void hastaneIsmiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hastaneIsmiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankalarDataSet);

        }

        private void HastaneIsımler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankalarDataSet.HastaneIsmi' table. You can move, or remove it, as needed.
            this.hastaneIsmiTableAdapter.Fill(this.bankalarDataSet.HastaneIsmi);

        }
    }
}
