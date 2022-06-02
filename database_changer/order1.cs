using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_changer
{
    public partial class order1 : Form
    {
        public order1()
        {
            InitializeComponent();
        }

        private void order1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void order1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.order1". При необходимости она может быть перемещена или удалена.
            this.order1TableAdapter.Fill(this.shopDataSet.order1);

        }
    }
}
