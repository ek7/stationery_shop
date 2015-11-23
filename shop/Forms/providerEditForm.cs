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
    public partial class providerEditForm : Form
    {
        private bool isEdit;
        private int Id;

        public providerEditForm()
        {
            InitializeComponent();
            isEdit = false;
        }
        public providerEditForm(int id,string name,string adress, string phone)
        {
            InitializeComponent();
            isEdit = true;
            Id = id;
            this.firmName.Text = name;
            this.Adress.Text = adress;
            this.Phone.Text = phone;
        }
        private void editProvider() 
        {
            providerTableAdapter.UpdateQuery(Phonenumber.Text, firm.Text, adr.Text, Id);
        }
        private void addProvider() 
        {
            providerTableAdapter.InsertQuery(Phonenumber.Text, firm.Text, adr.Text);
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
                    editProvider();
                    MessageBox.Show("Запись обновлена");
                }
                else
                {
                    addProvider();
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
