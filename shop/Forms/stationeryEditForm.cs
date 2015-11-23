using System;
using System.Windows.Forms;

namespace shop.Forms
{
    public partial class stationeryEditForm : Form
    {
        private bool isEdit;
        private int pid;

        public stationeryEditForm()
        {
            InitializeComponent();
            isEdit = false;
        }
        public stationeryEditForm(int id, string name,string price,string manufacturer,string articul, int inShop, int inStock,int id_department,int id_provider)
        {
            InitializeComponent();
            isEdit = true;
            pid = id;
            this.ProductName.Text = name;
            this.Price.Text = price;
            this.Manufacturer.Text = manufacturer;
            this.Articul.Text = articul;
            this.inShop.Text = Convert.ToString(inShop);
            this.inStock.Text = Convert.ToString(inStock);
            this.idDepartment.SelectedValue = id_department;
            this.idProvider.SelectedValue = id_provider;
        }

        private void stationeryEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet.provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.shopdbDataSet.provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet.department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.shopdbDataSet.department);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void editStationery()
        {
            _stationeryTableAdapter.UpdateQuery(Convert.ToInt32(inShop.Text),
                Convert.ToInt32(inStock.Text),Convert.ToInt32(idProvider.SelectedValue),
                Convert.ToInt32(idDepartment.SelectedValue),ProductName.Text,Price.Text,
                Manufacturer.Text,Articul.Text,pid);
        }

        private void addStationery()
        {
            _stationeryTableAdapter.InsertQuery(Convert.ToInt32(inShop.Text),
                Convert.ToInt32(inStock.Text),Convert.ToInt32(idProvider.SelectedValue),
                Convert.ToInt32(idDepartment.SelectedValue),ProductName.Text,Price.Text,
                Manufacturer.Text,Articul.Text);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdit)
                {
                    editStationery();
                    MessageBox.Show("Запись обновлена");
                }
                else
                {
                    addStationery();
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
