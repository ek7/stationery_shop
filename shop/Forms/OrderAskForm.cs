using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop.Forms
{
    public partial class OrderAskForm : Form
    {
        private int Count, selPrice;

        public OrderAskForm(int count, int price)
        {
            InitializeComponent();
            Count = count;
            selPrice = price;
        }
        public int Number
        {
            get
            {
                return Convert.ToInt32(numeric.Value.ToString());
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(numeric.Value.ToString());
            if (value < Count)
            {
                price.Text = Convert.ToString(value * selPrice);
            }
            else 
            {
                MessageBox.Show("В магазине недостаточно запрашиваемого товара");
            }
        }
    }
}
