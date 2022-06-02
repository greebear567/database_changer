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
    public partial class user1 : Form
    {
        public user1()
        {
            
            InitializeComponent();
        }

        private void user1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string str = nameTextBox.Text;
            int engCount = 0;
            int rusCount = 0;
            foreach (char c in str)
            {
                if ((c > 'а' && c < 'я') || (c > 'А' && c < 'Я'))
                    rusCount++;
                else if ((c > 'a' && c < 'z') || (c > 'A' && c < 'Z'))
                    engCount++;
            }

            string str2 = passwordTextBox.Text;
            int engCount2 = 0;
            int rusCount2 = 0;
            foreach (char c in str2)
            {
                if ((c > 'а' && c < 'я') || (c > 'А' && c < 'Я'))
                    rusCount2++;
                else if ((c > 'a' && c < 'z') || (c > 'A' && c < 'Z'))
                    engCount2++;
            }

            string str1 = addressTextBox.Text;
            int engCount1 = 0;
            int rusCount1 = 0;
            foreach (char c in str1)
            {
                if ((c > 'а' && c < 'я') || (c > 'А' && c < 'Я'))
                    rusCount1++;
                else if ((c > 'a' && c < 'z') || (c > 'A' && c < 'Z'))
                    engCount1++;
            }

            if (passwordTextBox.TextLength < 7)
            {
                MessageBox.Show("Пароль должен состоять не менее чем из 7 символов!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            } else
            if (rusCount>0 || rusCount1>0 || rusCount2 > 0)
            {
                MessageBox.Show("Используйте только латинские буквы при заполнении базы данных!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.user1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shopDataSet);
            }

        }

        private void user1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.user1". При необходимости она может быть перемещена или удалена.
            this.user1TableAdapter.Fill(this.shopDataSet.user1);
        }
    }
}
