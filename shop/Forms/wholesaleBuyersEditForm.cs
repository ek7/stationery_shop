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
    public partial class wholesaleBuyersEditForm : Form
    {
        private bool isEdit;
        private int Id;
        public wholesaleBuyersEditForm()
        {
            InitializeComponent();
            isEdit = false;
        }
        public wholesaleBuyersEditForm(int id,string snp,string phone,string email)
        {
            InitializeComponent();
            isEdit = true;
            Id = id;
            this.Email.Text = email;
            this.SNP.Text = snp;
            this.Phone.Text = phone;
        }
        private void addBuyer()
        {
            wholesale_buyersTableAdapter.InsertQuery(SNP.Text, Phone.Text, Email.Text);
        }
        private void editBuyer() 
        {
            wholesale_buyersTableAdapter.UpdateQuery(SNP.Text, Phone.Text, Email.Text, Id);
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
                    editBuyer();
                    MessageBox.Show("Запись обновлена");
                }
                else
                {
                    addBuyer();
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
