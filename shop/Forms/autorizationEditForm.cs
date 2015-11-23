using System.Windows.Forms;
using System;

namespace shop.Forms
{
    public partial class autorizationEditForm : Form
    {
        private bool isEdit;
        private int pid;

        public autorizationEditForm()
        {
            InitializeComponent();
            isEdit = false;
        }

        public autorizationEditForm(string snp,string job,string passport_number,string login,string password) 
        {
            InitializeComponent();
            isEdit = true;
            this.SNP.Text = snp;
            this.Job.Text = job;
            this.PassprtCode.Text = passport_number;
            this.Login.Text = login;
            this.Passwd.Text = password;
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (isEdit)
                {
                    editAutorz();
                    MessageBox.Show("Запись обновлена");
                }
                else
                {
                    addAutorz();
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

        private void editAutorz()
        {
            autorizationTableAdapter.UpdateQuery(SNP.Text, Job.Text,
                PassprtCode.Text, Login.Text, Passwd.Text, PassprtCode.Text);
        }
        private void addAutorz() 
        {
            autorizationTableAdapter.InsertQuery(SNP.Text, Job.Text,
                PassprtCode.Text, Login.Text, Passwd.Text);
        }
    }
}
