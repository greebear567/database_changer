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
    public partial class product1 : Form
    {
        public product1()
        {
            InitializeComponent();
        }

        private void product1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string str = typeTextBox.Text;
            int engCount = 0;
            int rusCount = 0;
            foreach (char c in str)
            {
                if ((c > 'а' && c < 'я') || (c > 'А' && c < 'Я'))
                    rusCount++;
                else if ((c > 'a' && c < 'z') || (c > 'A' && c < 'Z'))
                    engCount++;
            }

            string str1 = proportionsTextBox.Text;
            int engCount1 = 0;
            int rusCount1 = 0;
            foreach (char c in str1)
            {
                if ((c > 'а' && c < 'я') || (c > 'А' && c < 'Я'))
                    rusCount1++;
                else if ((c > 'a' && c < 'z') || (c > 'A' && c < 'Z'))
                    engCount1++;
            }

            if (rusCount > 0 || rusCount1 > 0)
            {
                MessageBox.Show("При заполнении базы данных используйте только латинские буквы!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {


                this.Validate();
                this.product1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shopDataSet);
            }

        }

        private void product1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.product1". При необходимости она может быть перемещена или удалена.
            this.product1TableAdapter.Fill(this.shopDataSet.product1);

        }
    }
}
