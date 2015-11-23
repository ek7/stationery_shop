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
    public partial class departmentEditForm : Form
    {
        private bool isEdit;
        private int depID;

        public departmentEditForm()
        {
            InitializeComponent();
            isEdit = false;
        }
        public departmentEditForm(int id,string department_name,string description) 
        {
            InitializeComponent();
            isEdit = true;
            depID = id;
            this.departmentName.Text = department_name;
            this.Description.Text = description;
        }
        private void editDepartment()        
        {
            departmentTableAdapter.UpdateQuery(departmentName.Text,Description.Text,depID);
        }

        private void addDepartment() 
        {
            departmentTableAdapter.InsertQuery(departmentName.Text, Description.Text);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdit)
                {
                    editDepartment();
                    MessageBox.Show("Запись обновлена");
                }
                else
                {
                    addDepartment();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
