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
    public partial class wholesaleOrdersEditForm : Form
    {
        private bool isEdit;
        private int idBuyer, idProduct;

        public wholesaleOrdersEditForm()
        {
            InitializeComponent();
            isEdit = false;
        }
        public wholesaleOrdersEditForm(int idproduct,int idbuyer,string count,string date)
        {
            InitializeComponent();
            isEdit = true;
            idBuyer = idbuyer;
            idProduct = idproduct;
            this.productId.SelectedValue = idproduct;
            this.buyerId.SelectedValue = Convert.ToString(idbuyer);
            this.Count.Text = count;
            this.Date.Value = Convert.ToDateTime(date);
        }
        private void wholesaleOrdersEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet.wholesale_buyers". При необходимости она может быть перемещена или удалена.
            this.wholesale_buyersTableAdapter.Fill(this.shopdbDataSet.wholesale_buyers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet._stationery". При необходимости она может быть перемещена или удалена.
            this._stationeryTableAdapter.Fill(this.shopdbDataSet._stationery);

        }
        private void addOrder() 
        {
           wholesale_ordersTableAdapter.InsertQuery(Convert.ToInt32(productId.SelectedValue),
               Convert.ToInt32(buyerId.SelectedValue),Convert.ToInt32(Count.Text),Date.Value.ToString());
        }
        private void editOrder() 
        {
            wholesale_ordersTableAdapter.UpdateQuery(Convert.ToInt32(productId.SelectedValue),
               Convert.ToInt32(buyerId.SelectedValue), Convert.ToInt32(Count.Text), Date.Value.ToString(), idProduct, idBuyer);
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdit)
                {
                    editOrder();
                    MessageBox.Show("Запись обновлена");
                }
                else
                {
                    addOrder();
                    MessageBox.Show("Запись добавлена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            this.Close();
        }
    }
}
