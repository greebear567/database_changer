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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователь")
            {
                user1 some = new user1();
                some.ShowDialog();
            }
            if (comboBox1.Text == "Производитель")
            {
                manufacturer1 some = new manufacturer1();
                some.ShowDialog();
            }
            if (comboBox1.Text == "Товар")
            {
                product1 some = new product1();
                some.ShowDialog();
            }
            if (comboBox1.Text == "Корзина")
            {
                cart some = new cart();
                some.ShowDialog();
            }
            if (comboBox1.Text == "Заказ")
            {
                order1 some = new order1();
                some.ShowDialog();
            }
        }
    }
}
