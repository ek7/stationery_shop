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
    public partial class salesEditForm : Form
    {
        private bool isEdit;
        private int Id;
        public salesEditForm()
        {
            InitializeComponent();
            isEdit = false;
        }
        public salesEditForm(int id,string seled,string price,string date)
        {
            InitializeComponent();
            isEdit = true;
            Id = id;
            this.id_product.SelectedValue = id;
            this.Saled.Text = seled;
            this.Price.Text = price;
            this.Date.Value = Convert.ToDateTime(date);
        }

        private void salesEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet._stationery". При необходимости она может быть перемещена или удалена.
            this._stationeryTableAdapter.Fill(this.shopdbDataSet._stationery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet._stationery". При необходимости она может быть перемещена или удалена.
           // this._stationeryTableAdapter.Fill(this.shopdbDataSet._stationery);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addSale() 
        {
            account_salesTableAdapter.InsertQuery(Convert.ToInt32(id_product.SelectedValue), Saled.Text, Price.Text, Date.Value.ToString());
        }
        private void editSale() 
        {
            account_salesTableAdapter.UpdateQuery(Convert.ToInt32(id_product.SelectedValue), Saled.Text, Price.Text,Id, Date.Value.ToString());
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdit)
                {
                    editSale();
                    MessageBox.Show("Запись обновлена");
                }
                else
                {
                    addSale();
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
